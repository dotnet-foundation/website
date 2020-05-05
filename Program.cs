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
        .BuildPipeline(
          "projects-json-generation",
          builder => builder
            .WithInputReadFiles("projects/data/*.md")
            .WithProcessModules(new RenderProjectsJsonModule())
            .WithOutputWriteFiles(Path.Combine("projects", "projects.json"))
        )
        .RunAsync();
    }
  }
}
