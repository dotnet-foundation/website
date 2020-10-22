using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.SyndicationFeed;
using Microsoft.SyndicationFeed.Atom;
using Microsoft.SyndicationFeed.Rss;
using Statiq.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;

namespace DotnetFoundationWeb
{
    public class GetBlogFeeds : ParallelModule
    {
        private DateTimeOffset _recent;

        protected override void BeforeExecution(IExecutionContext context)
        {
            _recent = new DateTimeOffset(
                DateTime.Today.AddHours(context.ApplicationState.IsCommand("preview") || context.Settings.GetBool("dev") ? -168 : -48));
        }

        protected override async Task<IEnumerable<IDocument>> ExecuteInputAsync(IDocument input, IExecutionContext context)
        {
            string feed = input.GetString("Feed");
            if (!string.IsNullOrEmpty(feed))
            {
                try
                {
                    // Download the feed
                    context.LogInformation($"Getting feed for {feed}");
                    Uri website = null;
                    string title = null;
                    string author = null;
                    string description = null;
                    string image = null;
                    List<ISyndicationItem> items = new List<ISyndicationItem>();
                    using (HttpClient httpClient = context.CreateHttpClient())
                    {

                        httpClient.DefaultRequestHeaders.Add("User-Agent", "Wyam");

                        var response = await httpClient.GetAsync(feed);
                        if (response.StatusCode == HttpStatusCode.Redirect ||
                            response.StatusCode == HttpStatusCode.MovedPermanently)
                        {
                            context.LogWarning($"Attempting to follow redirect for {feed}");
                            feed = response.Headers.Location.OriginalString;
                            response = await httpClient.GetAsync(feed);
                        }

                        if (response.IsSuccessStatusCode)
                        {
                            using (Stream stream = await response.Content.ReadAsStreamAsync())
                            using (StreamReader streamReader = new XmlStreamReader(stream))
                            using (XmlReader xmlReader = XmlReader.Create(streamReader, new XmlReaderSettings { Async = true, DtdProcessing = DtdProcessing.Ignore }))
                            {
                                xmlReader.MoveToContent();
                                bool atom = xmlReader.Name == "feed";
                                context.LogInformation($"Reading {feed} as " + (atom ? "Atom" : "RSS"));
                                XmlFeedReader feedReader = atom
                                    ? (XmlFeedReader)new AtomFeedReader(xmlReader, new FixedAtomParser())
                                    : new RssFeedReader(xmlReader);
                                while (await feedReader.Read())
                                {
                                    try
                                    {
                                        switch (feedReader.ElementType)
                                        {
                                            case SyndicationElementType.Person:
                                                ISyndicationPerson person = await feedReader.ReadPerson();
                                                if (person.RelationshipType == "author")
                                                {
                                                    author = person.Name ?? person.Email;
                                                }
                                                break;

                                            case SyndicationElementType.Image:
                                                ISyndicationImage img = await feedReader.ReadImage();
                                                image = img.Url.ToString();
                                                break;

                                            case SyndicationElementType.Link:
                                                ISyndicationLink link = await feedReader.ReadLink();
                                                website = link.Uri;
                                                break;

                                            case SyndicationElementType.Item:
                                                ISyndicationItem item = await feedReader.ReadItem();
                                                items.Add(item);
                                                break;

                                            case SyndicationElementType.None:
                                                break;

                                            default:
                                                ISyndicationContent content = await feedReader.ReadContent();
                                                if (string.Equals(content.Name, "title", StringComparison.OrdinalIgnoreCase))
                                                {
                                                    title = content.Value;
                                                }
                                                else if (string.Equals(content.Name, "description", StringComparison.OrdinalIgnoreCase)
                                                    || string.Equals(content.Name, "subtitle", StringComparison.OrdinalIgnoreCase))
                                                {
                                                    description = content.Value;
                                                }
                                                break;
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        context.LogWarning($"Exception while processing {feedReader.ElementType} in {feed}: {ex.Message}");
                                    }
                                }
                            }
                        }

                        // Get a new document with feed metadata
                        MetadataItems metadata = new MetadataItems();
                        if (items.Count > 0)
                        {
                            BlogFeedItem[] feedItems = items
                                .Select(x => new BlogFeedItem(x, _recent, website))
                                .OrderByDescending(x => x.Published)
                                .Take(50) // Only take the 50 most recent items
                                .ToArray();
                            metadata.Add(SiteKeys.BlogFeedItems, feedItems);
                            return input.Clone(metadata).Yield();
                        }
                    }
                }
                catch (Exception ex)
                {
                    context.LogWarning($"Error getting feed for {feed}: {ex.Message}");
                }
            } 
            else 
            {
              var speaker = input.GetString("Title");
              if (!string.IsNullOrWhiteSpace(speaker))
              {
                context.LogInformation($"No RSS specified for {speaker}.");
              }
              else
              {
                context.LogInformation($"No RSS specified for unknown speaker.");
              }
            }
            return input.Yield();
        }
    }
}
