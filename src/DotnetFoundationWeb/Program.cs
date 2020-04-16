using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetFoundationWeb.Modules;
using Statiq.App;
using Statiq.Common;
using Statiq.Web;

namespace DotnetFoundationWeb
{

  public static class Program
  {
    public static async Task<int> Main(string[] args)
    {
      return await Bootstrapper.Factory
        .CreateWeb(args)
        .AddSetting(
          Keys.DestinationPath,
          Config.FromDocument(
              doc => GetPath(doc)))
        .BuildPipeline(
          "projects-json-generation",
          builder => builder
            .WithInputReadFiles("**/data/projects/*.md")
            .WithProcessModules(new RenderProjectsJsonModule())
        )
        .RunAsync();
    }

    public static FilePath GetPath(IDocument doc)
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
      else
      {
        return doc.Destination.ChangeExtension(".html");
      }
    }
  }
}
