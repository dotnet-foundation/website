using Statiq.Common;
using System.Linq;

namespace DotnetFoundationWeb
{
    public class ValidateSpeakerPronouns : SpeakerDataAnalyzer
    {
        protected override void AnalyzeSpeakerData(IDocument document, IAnalyzerContext context)
        {
            string pronouns = document.GetString(SiteKeys.Pronouns);
            if (!pronouns.IsNullOrEmpty() && (pronouns.Count(x => x == '/') != 1 || pronouns.Any(x => x != '/' && (!char.IsLetter(x) || !char.IsLower(x)))))
            {
                context.AddAnalyzerResult(document, $"Preferred gender pronouns should be of the form [subject]/[object] in lowercase (I.e. \"they/them\")");
            }
        }
    }
}
