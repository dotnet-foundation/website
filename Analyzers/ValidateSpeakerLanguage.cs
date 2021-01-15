using Statiq.Common;
using System.Collections.Generic;
using System.Linq;

namespace DotnetFoundationWeb
{
    public class ValidateSpeakerLanguage : SpeakerDataAnalyzer
    {
        protected override void AnalyzeSpeakerData(IDocument document, IAnalyzerContext context)
        {
            IReadOnlyList<string> languages = document.GetList<string>(SiteKeys.Language);
            if (languages?.Count > 0)
            {
                foreach (string language in languages)
                {
                    if (!char.IsUpper(language[0]))
                    {
                        context.AddAnalyzerResult(document, $"Please capitalize speaker language: {language}");
                    }
                }
            }
        }
    }
}
