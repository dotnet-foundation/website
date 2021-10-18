using System;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
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
            if (!string.IsNullOrWhiteSpace(AppSettings.ServerUrl))
            {
                var formatterString = AppSettings.ServerUrl + "/{0}";
                formatter = f => string.Format(formatterString, f);
            }

            var bootstrapper = Bootstrapper.Factory
                .CreateWeb(args)
                .AddSetting(WebKeys.InputFiles, new[] { "**/{!_,}*", "_redirects" })
                .AddSetting(Keys.Host, "dotnetfoundation.org")
                .AddSetting(Keys.LinksUseHttps, true)
                .AddSetting(WebKeys.MirrorResources, true)
                .AddSetting(WebKeys.ExcludedPaths, "api/node_modules");

            // No IConfiguration so I'm looking at the environment variable
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE__ENVIRONMENT") ?? "Production";
            if (environment == "Development" && AppSettings.SuppressProjects)
            {
                Console.WriteLine("Suppressing Project Generation ****SHOULD ONLY BE IN DEBUG***");
            }
            else
            {
                bootstrapper = AddProjectsPipeline(bootstrapper);
            }

            if (environment == "Development" && AppSettings.SuppressSpeakers)
            {
                Console.WriteLine("Suppressing Speakers Generation ****SHOULD ONLY BE IN DEBUG***");
            }
            else
            {
                bootstrapper = AddSpeakersPipeline(bootstrapper);
            }

            return await bootstrapper.RunAsync();
        }

        private static Bootstrapper AddSpeakersPipeline(Bootstrapper bootstrapper)
        {
            bootstrapper = bootstrapper.ModifyPipeline(
              nameof(Statiq.Web.Pipelines.Content),
              x => x.ProcessModules.Add(
                  // Modules for speakers
                  new ExecuteSources("community/speakers/*.md")
                  {
                    new GeocodeLocations(Config.FromSetting(SiteKeys.AzureMapsSubscriptionKey)),
                    new GetBlogFeeds(),
                    new SpeakerImage()
                  }
              ));
            return bootstrapper;
        }

        private static Bootstrapper AddProjectsPipeline(Bootstrapper bootstrapper)
        {
            bootstrapper = bootstrapper.BuildPipeline(
              "GenerateProjectsJson",
              builder => builder
                  .WithDependencies(nameof(Statiq.Web.Pipelines.Content))
                  .WithProcessModules(
                      new ReplaceDocuments(nameof(Statiq.Web.Pipelines.Content)),
                      new FlattenTree(),
                      new FilterSources("projects/data/*.md"),
                      new ExecuteConfig(Config.FromContext(ctx =>
                          JsonSerializer.Serialize(ctx.Inputs.Select(x => new
                          {
                              Title = x.GetString(WebKeys.Title),
                              Keywords = x.GetString(SiteKeys.Keywords),
                              Link = x.GetLink(),
                              Content = x.GetContentStringAsync().GetAwaiter().GetResult()
                          })
                      )))
                  )
                  .WithOutputWriteFiles("projects/projects.json"));

            return bootstrapper;
        }
    }
}
