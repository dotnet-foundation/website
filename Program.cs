using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DotnetFoundationWeb.Modules;
using Statiq.App;
using Statiq.Common;
using Statiq.Core;
using Statiq.Web;

namespace DotnetFoundationWeb
{

  public static class Program
  {
    public static async Task<int> Main(string[] args)
    {
      Func<string, string> formatter = null;
      if (!string.IsNullOrWhiteSpace(AppSettings.ServerUri))
      {
        var formatterString = AppSettings.ServerUri + "/{0}";
        formatter = f => string.Format(formatterString, f);
      }

      return await Bootstrapper.Factory
        .CreateWeb(args)
        .AddSetting(Keys.Host, "dotnetfoundation.org")
        .AddSetting(Keys.LinksUseHttps, true)
        .AddSetting(
          Keys.DestinationPath,
          Config.FromDocument(
              doc => GetPath(doc)))
        .AddSetting(
          Keys.SitemapItem,
          Config.FromDocument(
              doc =>
              {
                var siteMapItem = new SitemapItem(GetPath(doc).FullPath);
                return siteMapItem;
              }))
        .BuildPipeline(
          "projects-json-generation",
          builder => builder
            .WithInputReadFiles("__data/projects/*.md")
            .WithProcessModules(new RenderProjectsJsonModule())
            .WithOutputWriteFiles(Path.Combine("projects", "projects.json"))
        )
        .RunAsync();
    }

    static NormalizedPath GetPath(IDocument doc)
    {
      if (doc.Source.Segments[^2].SequenceEqual("posts".AsMemory()))
      {
        return new NormalizedPath("blog")
          .Combine(new NormalizedPath(doc.Get<DateTime>("Published").ToString("yyyy/MM/dd")))
          .Combine(doc.Destination.FileName.ChangeExtension(".html"));
      }
      else if (doc.Source.Segments[^2].SequenceEqual("campaign-2019".AsMemory()))
      {
        return new NormalizedPath("about/election/campaign-2019")
          .Combine(doc.Destination.FileName.ChangeExtension(".html"));
      }
      else if (doc.Source.Segments[^2].SequenceEqual("projects".AsMemory()))
      {
        return new NormalizedPath("projects")
          .Combine(doc.Destination.FileName.ChangeExtension(".html"));
      }
      else if (doc.Source.Segments[^2].SequenceEqual("committees".AsMemory()))
      {
        return new NormalizedPath("community/committees")
          .Combine(doc.Destination.FileName.ChangeExtension(".html"));
      }
      else
      {
        return doc.Destination.ChangeExtension(".html");
      }
    }
  }
}
