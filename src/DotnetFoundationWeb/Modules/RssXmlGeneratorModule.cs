using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetFoundationWeb.Models;
using DotnetFoundationWeb.Utils;
using Statiq.Common;

namespace DotnetFoundationWeb.Modules
{
  public class RssXmlGeneratorModule : Module
  {
    /// <inheritdoc />
    protected override async Task<IEnumerable<IDocument>> ExecuteContextAsync(IExecutionContext context)
    {
      var posts = new List<Post>();
      StringBuilder sb = new StringBuilder();
      sb.Append("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?><rss version=\"2.0\" xmlns:atom=\"http://www.w3.org/2005/Atom\">");
      sb.Append("<channel>");
		  sb.Append("<title>Blog</title>");
		  sb.AppendFormat("<link>{0}/blog</link>", AppSettings.ServerUri);
		  sb.Append("<description>Welcome to my blog</description>");
		  sb.Append("<language>en-US</language>");
		  sb.AppendFormat("<pubDate>{0}</pubDate>", DateTime.Now);
		  sb.Append("<docs>http://blogs.law.harvard.edu/tech/rss</docs>");
		  sb.Append("<ttl>60</ttl>");
		  sb.AppendFormat("<managingEditor>{0}</managingEditor>", AppSettings.ContactEmail);
		  sb.AppendFormat("<webMaster>{0}</webMaster>", AppSettings.ContactEmail);
      sb.AppendFormat("<atom:link href=\"{0}/api/rss\" rel=\"self\" type=\"application/rss+xml\"/>", AppSettings.ServerUri);
      foreach (IDocument input in context.Inputs)
      {
        await AddToSiteMapAsync(input);
      }

      foreach (Post post in posts.OrderByDescending(post => post.Published))
      {
        AddPost(sb, post);
      }
      sb.Append("</channel></rss>");
      return context.CreateDocument( await context.GetContentProviderAsync(sb.ToString(), MediaTypes.Xml)).Yield();

      async Task AddToSiteMapAsync(IDocument input)
      {
        var fileContent = await input.GetContentStringAsync();
        var content = StringUtils.GetDocContent(fileContent);
        var publishedDate = DateTime.Parse(StringUtils.GetDocValue("Published", fileContent));
        var documentUrl = $"/blog/{publishedDate.ToString("yyyy/MM/dd")}/{input.Source.FileNameWithoutExtension}";
        posts.Add(new Post
        {
          Title = input.GetTitle(),
          Description = FixContent(content, AppSettings.ServerUri),
          Link = documentUrl,
          Published = publishedDate
        });
        
      }
    }

    private void AddPost(StringBuilder sb, Post post)
    {
      sb.Append("<item>");
      sb.AppendFormat("<title>{0}</title>", post.Title);
      sb.AppendFormat("<description><![CDATA[{0}]]></description>", post.Description);
      sb.AppendFormat("<link>{0}{1}</link>", AppSettings.ServerUri, post.Link);
      sb.AppendFormat("<guid>{0}{1}</guid>", AppSettings.ServerUri, post.Link);
      sb.AppendFormat("<pubDate>{0}</pubDate>", post.Published.ToString("r"));
      sb.Append($"</item>");
    }

    private string FixContent(string content, string serverUri)
    {
      content = Markdig.Markdown.ToHtml(content);
      content = content.Replace("\"assets", $"\"{serverUri}/assets");
      content = content.Replace("\"\\assets", $"\"\\{serverUri}/assets");
      return content;
    }
  }
}
