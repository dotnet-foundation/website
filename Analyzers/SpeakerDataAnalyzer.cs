using Microsoft.Extensions.Logging;
using Statiq.Common;
using Statiq.Web.Pipelines;

namespace DotnetFoundationWeb
{
    public abstract class SpeakerDataAnalyzer : SyncAnalyzer
    {
        public override LogLevel LogLevel { get; set; } = LogLevel.Error;

        protected SpeakerDataAnalyzer()
        {
            PipelinePhases.Add(nameof(AnalyzeContent), Phase.Process);
        }

        protected override sealed void Analyze(IAnalyzerContext context)
        {
            foreach (IDocument document in context.Inputs.FilterSources("community/speakers/*.md"))
            {
                AnalyzeSpeakerData(document, context);
            }
        }

        protected abstract void AnalyzeSpeakerData(IDocument document, IAnalyzerContext context);
    }
}
