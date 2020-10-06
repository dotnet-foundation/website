using System;
using System.Collections.Immutable;
using Microsoft.Extensions.Logging;
using Statiq.Common;

namespace DotnetFoundationWeb
{
    public class ValidateSpeakerLinks : SpeakerDataAnalyzer
    {
        protected override void AnalyzeSpeakerData(IDocument document, IAnalyzerContext context)
        {
            foreach (string linkKey in SpeakerLinkAttribute.GetAll().Keys)
            {
                if (document.ContainsKey(linkKey) && !Uri.TryCreate(document.GetString(linkKey), UriKind.Absolute, out _))
                {
                    context.Add(document, $"{linkKey} link {document.GetString(linkKey)} is invalid");
                }
            }
        }
    }
}
