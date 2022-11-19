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
            var sources = new ExecuteSources("community/speakers/*.md");

            if (!AppSettings.SuppressSpeakerGeoLocation)
            {
                sources.Add(new GeocodeLocations(Config.FromSetting(SiteKeys.AzureMapsSubscriptionKey)));
            } 
            else
            {
                Console.WriteLine("Suppressing Geolocation extraction ****SHOULD ONLY BE IN DEBUG***");
            }

            if (!AppSettings.SuppressSpeakerBlogs)
            {
                sources.Add(new GetBlogFeeds());
            }
            else
            {
                Console.WriteLine("Suppressing Speaker Blog Entry retrieval ****SHOULD ONLY BE IN DEBUG***");
            }

            if (!AppSettings.SuppressSpeakerImages)
            {
                sources.Add(new SpeakerImage());
            }
            else
            {
                Console.WriteLine("Suppressing Speaker Images retrieval ****SHOULD ONLY BE IN DEBUG***");
            }

            bootstrapper = bootstrapper.ModifyPipeline(
              nameof(Statiq.Web.Pipelines.Content),
              x => x.ProcessModules.Add(sources));
            
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
