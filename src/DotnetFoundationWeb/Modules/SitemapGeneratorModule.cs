using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetFoundationWeb.Utils;
using Statiq.Common;
using Statiq.Core;
using Statiq.Web;

namespace DotnetFoundationWeb.Modules
{
  public class SitemapGeneratorModule : Module
  {
    private static readonly string[] ChangeFrequencies = { "always", "hourly", "daily", "weekly", "monthly", "yearly", "never" };

    private readonly Config<object> _sitemapItemOrLocation;
    private readonly Func<string, string> _locationFormatter;

    /// <summary>
    /// Creates a site map using the metadata key <c>SitemapItem</c> which should contain either a <c>string</c> that
    /// contains the location for each input document or a <c>SitemapItem</c> instance with the location
    /// and other information. If the key <c>SitemapItem</c> is not found or does not contain the correct type of object,
    /// a link to the document will be used.
    /// </summary>
    /// <param name="locationFormatter">A location formatter that will be applied to the location of each input after
    /// getting the value of the <c>SitemapItem</c> metadata key.</param>
    public SitemapGeneratorModule(Func<string, string> locationFormatter = null)
        : this(Config.FromDocument(Keys.SitemapItem), locationFormatter)
    {
    }

    /// <summary>
    /// Creates a site map using the specified metadata key which should contain either a <c>string</c> that
    /// contains the location for each input document or a <c>SitemapItem</c> instance with the location
    /// and other information. If the metadata key is not found or does not contain the correct type of object,
    /// a link to the document will be used.
    /// </summary>
    /// <param name="sitemapItemOrLocationMetadataKey">A metadata key that contains either a <c>SitemapItem</c> or
    /// a <c>string</c> location for each input document.</param>
    /// <param name="locationFormatter">A location formatter that will be applied to the location of each input after
    /// getting the value of the specified metadata key.</param>
    public SitemapGeneratorModule(string sitemapItemOrLocationMetadataKey, Func<string, string> locationFormatter = null)
        : this(Config.FromDocument(sitemapItemOrLocationMetadataKey), locationFormatter)
    {
      if (string.IsNullOrEmpty(sitemapItemOrLocationMetadataKey))
      {
        throw new ArgumentException("Argument is null or empty", nameof(sitemapItemOrLocationMetadataKey));
      }
    }

    /// <summary>
    /// Creates a site map using the specified delegate which should return either a <c>string</c> that
    /// contains the location for each input document or a <c>SitemapItem</c> instance with the location
    /// and other information. If the delegate returns <c>null</c> or does not return the correct type of object,
    /// a link to the document will be used.
    /// </summary>
    /// <param name="sitemapItemOrLocation">A delegate that either returns a <c>SitemapItem</c> instance or a <c>string</c>
    /// with the desired item location. If the delegate returns <c>null</c>, the input document is not added to the site map.</param>
    /// <param name="locationFormatter">A location formatter that will be applied to the location of each input after
    /// getting the value of the specified metadata key.</param>
    public SitemapGeneratorModule(Config<object> sitemapItemOrLocation, Func<string, string> locationFormatter = null)
    {
      _sitemapItemOrLocation = sitemapItemOrLocation ?? throw new ArgumentNullException(nameof(sitemapItemOrLocation));
      _locationFormatter = locationFormatter;
    }

    /// <inheritdoc />
    protected override async Task<IEnumerable<IDocument>> ExecuteContextAsync(IExecutionContext context)
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?><urlset xmlns=\"http://www.sitemaps.org/schemas/sitemap/0.9\">");

      // Append the root site url first
      sb.Append("<url>");
      sb.AppendFormat("<loc>{0}</loc>", AppSettings.ServerUri);
      sb.AppendFormat("<lastmod>{0}</lastmod>", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ssZ"));
      sb.AppendFormat(CultureInfo.InvariantCulture, "<priority>{0}</priority>", "1.0");
      sb.Append("</url>");

      foreach (IDocument input in context.Inputs)
      {
        await AddToSiteMapAsync(input);
      }
      sb.Append("</urlset>");
      // Always output the site map document, even if it's empty
      return context.CreateDocument(await context.GetContentProviderAsync(sb.ToString(), MediaTypes.Xml)).Yield();

      async Task AddToSiteMapAsync(IDocument input)
      {
        if (!MustAddToSiteMap(input))
        {
          return;
        }
        // Try to get a SitemapItem
        object delegateResult = await _sitemapItemOrLocation.GetValueAsync(input, context);
        SitemapItem sitemapItem = delegateResult as SitemapItem
            ?? new SitemapItem((delegateResult as string) ?? context.GetLink(input));
        sitemapItem.Location = await GetFixedPath(input, sitemapItem.Location);
        sitemapItem.LastModUtc = input.GetPublishedDate(context);
        sitemapItem.Priority = GetDocPriorityForSitemap(sitemapItem.Location);

        // Add a site map entry if we got an item and valid location
        if (!string.IsNullOrWhiteSpace(sitemapItem?.Location))
        {
          string location = sitemapItem.Location;

          // Apply the location formatter if there is one
          if (_locationFormatter != null)
          {
            location = _locationFormatter(location);
          }

          // Location being null signals that this document should not be included in the site map
          if (!string.IsNullOrWhiteSpace(location))
          {
            sb.Append("<url>");
            sb.AppendFormat("<loc>{0}</loc>", location);

            if (sitemapItem.LastModUtc.HasValue)
            {
              sb.AppendFormat("<lastmod>{0}</lastmod>", sitemapItem.LastModUtc.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            }

            if (sitemapItem.ChangeFrequency.HasValue)
            {
              sb.AppendFormat("<changefreq>{0}</changefreq>", ChangeFrequencies[(int)sitemapItem.ChangeFrequency.Value]);
            }

            if (sitemapItem.Priority.HasValue)
            {
              sb.AppendFormat("<priority>{0}</priority>", sitemapItem.Priority.Value);
            }

            sb.Append("</url>");
          }
        }
      }
    }

    private double GetDocPriorityForSitemap(string location)
    {
      var pathSections = location.Split("/").Length;
      switch (pathSections)
      {
        case 1:
          return 1.0;
        case 2:
          return 0.8;
        default:
          return 0.6;
      }
    }

    private static bool MustAddToSiteMap(IDocument input)
    {
      if (input.Source.FileName.ToString().StartsWith("_"))
      {
        return false;
      }

      if (input.Source.FullPath.EndsWith("cshtml"))
      {
        return true;
      }

      if (input.Source.FullPath.EndsWith("md")
        && (input.Source.FullPath.Contains("posts")
          || input.Source.FullPath.Contains("campaign-2019")
          || input.Source.FullPath.Contains("projects")))
      {
        return true;
      }

      return false;
    }

    private async Task<string> GetFixedPath(IDocument input, string location)
    {
      if (input.Source.FullPath.Contains("posts"))
      {
        var fileContent = await input.GetContentStringAsync();
        var publishedDate = DateTime.Parse(StringUtils.GetDocValue("Published", fileContent));
        return $"blog/{publishedDate.ToString("yyyy/MM/dd")}/{input.Source.FileNameWithoutExtension}";
      }

      if (location.EndsWith("index.html"))
      {
        return location.Replace("index.html", string.Empty);
      }

      return location;
    }
  }
}
