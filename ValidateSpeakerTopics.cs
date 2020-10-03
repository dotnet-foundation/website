using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.Extensions.Logging;
using Statiq.Common;

namespace DotnetFoundationWeb
{
    public class ValidateSpeakerTopics : SyncAnalyzer
    {
        public static HashSet<string> ApprovedTopics = new HashSet<string>
        {
            ".NET",
            "Android",
            "ASP.NET",
            "ASP.NET MVC",
            "ASP.NET Web API",
            "Architecture",
            "Artificial Intelligence",
            "Azure",
            "Big Data",
            "Blazor",
            "C#",
            "Containers",
            "Data",
            "DevOps",
            "Diversity & Inclusion",
            "Entity Framework",
            "F#",
            "Game Development",
            "HoloLens",
            "iOS",
            "IoT",
            "Machine Learning",
            "macOS",
            "Microsoft 365",
            "Microsoft Graph",
            "Microsoft Teams",
            "Microservices",
            "Mixed Reality",
            "ML.NET",
            "Mobile Development",
            "NuGet",
            "Open Source",
            "Product Management",
            "Razor",
            "Security",
            "Serverless",
            "SignalR",
            "tvOS",
            "UWP",
            "Visual Basic",
            "Visual Studio",
            "Visual Studio Code",
            "Visual Studio for Mac",
            "watchOS",
            "Web Development",
            "Windows Development",
            "Windows Forms",
            "WPF",
            "Xamarin",
            "Xamarin.Forms"
        };

        public override LogLevel LogLevel { get; set; } = LogLevel.Error;

        public override string[] Pipelines => new[] { nameof(Statiq.Web.Pipelines.Content) };

        protected override void Analyze(ImmutableArray<IDocument> documents, IAnalyzerContext context)
        {
            foreach (IDocument document in documents.FilterSources("community/speakers/*.md"))
            {
                IReadOnlyList<string> topics = document.GetList<string>(SiteKeys.Topics);
                if (topics == null || topics.Count == 0)
                {
                    context.Add(document, "No topics specified");
                }
                string[] nonApprovedTopics = topics.Where(x => !ApprovedTopics.Contains(x)).ToArray();
                if (nonApprovedTopics.Length > 0)
                {
                    context.Add(document, $"Document contains non-approved topic(s): {string.Join(", ", nonApprovedTopics)}");
                }
            }
        }
    }
}
