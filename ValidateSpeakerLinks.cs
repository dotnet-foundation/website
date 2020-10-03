using System;
using System.Collections.Immutable;
using Microsoft.Extensions.Logging;
using Statiq.Common;

namespace DotnetFoundationWeb
{
    public class ValidateSpeakerLinks : SyncAnalyzer
    {
        public override LogLevel LogLevel { get; set; } = LogLevel.Error;

        public override string[] Pipelines => new[] { nameof(Statiq.Web.Pipelines.Content) };

        protected override void Analyze(ImmutableArray<IDocument> documents, IAnalyzerContext context)
        {
            foreach (IDocument document in documents.FilterSources("community/speakers/*.md"))
            {
                foreach (string socialLinkKey in SocialLinkAttribute.GetAll().Keys)
                {
                    if (document.ContainsKey(socialLinkKey) && !Uri.TryCreate(document.GetString(socialLinkKey), UriKind.Absolute, out _))
                    {
                        context.Add(document, $"{socialLinkKey} link {document.GetString(socialLinkKey)} is invalid");
                    }
                }
            }
        }
    }
}
