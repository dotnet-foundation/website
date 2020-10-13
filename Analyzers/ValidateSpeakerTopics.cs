using System.Collections.Generic;
using System.Linq;
using Statiq.Common;

namespace DotnetFoundationWeb
{
    public class ValidateSpeakerTopics : SpeakerDataAnalyzer
    {
        public static HashSet<string> Topics = new HashSet<string>
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
            "JavaScript",
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

        protected override void AnalyzeSpeakerData(IDocument document, IAnalyzerContext context)
        {
            IReadOnlyList<string> topics = document.GetList<string>(SiteKeys.Topics);
            if (topics == null || topics.Count == 0)
            {
                // No topics, but that's okay (if we ever want to enforce at least one topic, add an analyzer result here)
                return;
            }
            string[] nonApprovedTopics = topics.Where(x => !Topics.Contains(x)).ToArray();
            if (nonApprovedTopics.Length > 0)
            {
                context.Add(document, $"Document contains non-approved topic(s): {string.Join(", ", nonApprovedTopics)}");
            }
        }
    }
}
