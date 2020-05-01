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
        .BuildPipeline(
          "generate-sitemap",
          builder => builder
            .WithInputReadFiles("**/*")
            .WithInputModules(new SitemapGeneratorModule(formatter))
            .WithOutputWriteFiles("sitemap.xml")
        )
        .BuildPipeline(
          "rss-generation",
          builder => builder
            .WithInputReadFiles("__data/posts/*.md")
            .WithOutputModules(new RssXmlGeneratorModule())
            .WithOutputWriteFiles(Path.Combine("api", "rss", "index.xml"))
        )
        .RunAsync();
    }

    static FilePath GetPath(IDocument doc)
    {
      if (doc.Source.Directory.Segments.Last().SequenceEqual("posts".AsMemory()))
      {
        return new DirectoryPath("blog")
          .Combine(new DirectoryPath(doc.Get<DateTime>("Published").ToString("yyyy/MM/dd")))
          .CombineFile(doc.Destination.FileName.ChangeExtension(".html"));
      }
      else if (doc.Source.Directory.Segments.Last().SequenceEqual("campaign-2019".AsMemory()))
      {
        return new DirectoryPath("about/election/campaign-2019")
          .CombineFile(doc.Destination.FileName.ChangeExtension(".html"));
      }
      else if (doc.Source.Directory.Segments.Last().SequenceEqual("projects".AsMemory()))
      {
        return new DirectoryPath("projects")
          .CombineFile(doc.Destination.FileName.ChangeExtension(".html"));
      }
      else if (doc.Source.Directory.Segments.Last().SequenceEqual("committees".AsMemory()))
      {
        return new DirectoryPath("community/committees")
          .CombineFile(doc.Destination.FileName.ChangeExtension(".html"));
      }
      else
      {
        return doc.Destination.ChangeExtension(".html");
      }
    }
  }
}
