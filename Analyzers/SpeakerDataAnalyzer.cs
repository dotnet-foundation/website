using System.Collections.Immutable;
using Microsoft.Extensions.Logging;
using Statiq.Common;

namespace DotnetFoundationWeb
{
    public abstract class SpeakerDataAnalyzer : SyncAnalyzer
    {
        public override LogLevel LogLevel { get; set; } = LogLevel.Error;

        public override string[] Pipelines => new[] { nameof(Statiq.Web.Pipelines.Content) };

        protected override sealed void Analyze(ImmutableArray<IDocument> documents, IAnalyzerContext context)
        {
            foreach (IDocument document in documents.FilterSources("community/speakers/*.md"))
            {
                AnalyzeSpeakerData(document, context);
            }
        }

        protected abstract void AnalyzeSpeakerData(IDocument document, IAnalyzerContext context);
    }
}
