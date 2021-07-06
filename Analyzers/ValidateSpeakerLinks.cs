using Statiq.Common;
using System;
using System.Collections.Generic;

namespace DotnetFoundationWeb
{
    public class ValidateSpeakerLinks : SpeakerDataAnalyzer
    {
        protected override void AnalyzeSpeakerData(IDocument document, IAnalyzerContext context)
        {
            foreach (KeyValuePair<string, SpeakerLinkAttribute> linkAttribute in SpeakerLinkAttribute.GetAll())
            {
                if (document.ContainsKey(linkAttribute.Key))
                {
                    if (!Uri.TryCreate(document.GetString(linkAttribute.Key), UriKind.Absolute, out Uri uri))
                    {
                        context.AddAnalyzerResult(document, $"{linkAttribute.Key} link {document.GetString(linkAttribute.Key)} is invalid");
                    }
                    else if (linkAttribute.Value.EnforceHttps && uri.Scheme != Uri.UriSchemeHttps)
                    {
                        context.AddAnalyzerResult(document, $"{linkAttribute.Key} link should be HTTPS and was not");
                    }
                }
            }
        }
    }
}
