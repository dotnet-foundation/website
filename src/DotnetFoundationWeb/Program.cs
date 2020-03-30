using System;
using System.Linq;
using System.Threading.Tasks;
using Statiq.App;
using Statiq.Markdown;
using Statiq.Web;

namespace DotNetFoundation
{
    public static class Program
    {
          public static async Task<int> Main(string[] args) =>
              await Bootstrapper.Factory
                  .CreateWeb(args)
                  .BuildPipeline(
                      "input",
                      builder => builder
                          .WithInputReadFiles("**/*.md")
                          .WithProcessModules(new RenderMarkdown())
                          .WithOutputWriteFiles(".html"))
                  .RunAsync();
    }
}
