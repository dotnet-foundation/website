using Statiq.Common;
using System.Collections.Generic;

namespace DotnetFoundationWeb
{
    // Sets the speaker image metadata if not already provided
    public class SpeakerImage : SyncModule
    {
        protected override IEnumerable<IDocument> ExecuteInput(IDocument input, IExecutionContext context) =>
            input.GetString(SiteKeys.Image).IsNullOrWhiteSpace()
                ? input
                    .Clone(new MetadataItems
                    {
                        { SiteKeys.Image, input.ContainsKey(SiteKeys.GitHub) ? input.GetString(SiteKeys.GitHub).TrimEnd('/') + ".png" : "/img/dot_bot.png" }
                    })
                    .Yield()
                : input
                    .Yield();
    }
}
