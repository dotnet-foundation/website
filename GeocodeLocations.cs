using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Extensions.Logging;
using Statiq.Common;
using Statiq.Core;

namespace DotnetFoundationWeb
{
    // Looks for documents that contain "Location" metadata but not "Lat" and "Lon" and queries the Azure Maps API to add them
    public class GeocodeLocations : Module
    {
        public static readonly JsonSerializerOptions DefaultJsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        // Cache responses for each location
        private readonly ConcurrentDictionary<string, Task<CoordinateAbbreviated>> _coordinateCache =
            new ConcurrentDictionary<string, Task<CoordinateAbbreviated>>(StringComparer.OrdinalIgnoreCase);

        private readonly Config<string> _subscriptionKey;

        public GeocodeLocations(Config<string> subscriptionKey)
        {
            _subscriptionKey = subscriptionKey.ThrowIfNull(nameof(subscriptionKey));
            
            // Add coordinate overrides to cache
            _coordinateCache["the netherlands"] = Task.FromResult(new CoordinateAbbreviated { Lat = 52.371807, Lon = 4.896029 });
        }

        protected override async Task<IEnumerable<IDocument>> ExecuteInputAsync(IDocument input, IExecutionContext context)
        {
            if (input.ContainsKey(SiteKeys.Location) && !input.ContainsKey(SiteKeys.Lat) && !input.ContainsKey(SiteKeys.Lon))
            {
                string location = input.GetString(SiteKeys.Location);
                if (!location.IsNullOrWhiteSpace())
                {
                    CoordinateAbbreviated coordinates = await _coordinateCache.GetOrAdd(location, async _ =>
                    {
                        context.LogInformation($"Geocoding location {location} for {input.ToSafeDisplayString()}");
                        string subscriptionKey = await _subscriptionKey.GetValueAsync(input, context);
                        if (!subscriptionKey.IsNullOrWhiteSpace())
                        {
                            using (HttpClient client = context.CreateHttpClient())
                            {
                                HttpResponseMessage responseMessage = await client.SendWithRetryAsync($"https://atlas.microsoft.com/search/address/json?&subscription-key={subscriptionKey}&api-version=1.0&language=en-US&limit=1&query={HttpUtility.UrlEncode(location)}");
                                if (responseMessage.IsSuccessStatusCode)
                                {
                                    SearchAddressResponse searchAddressResponse;
                                    using (Stream responseStream = await responseMessage.Content.ReadAsStreamAsync())
                                    {
                                        searchAddressResponse = await JsonSerializer.DeserializeAsync<SearchAddressResponse>(responseStream, DefaultJsonSerializerOptions);
                                    }
                                    if (searchAddressResponse.Results.Length > 0)
                                    {
                                        return searchAddressResponse.Results[0].Position;
                                    }
                                    else
                                    {
                                        context.LogWarning($"No results while geocoding location {location} for {input.ToSafeDisplayString()}");
                                    }
                                }
                                else
                                {
                                    context.LogWarning($"Error {responseMessage.StatusCode} while geocoding location {location} for {input.ToSafeDisplayString()}");
                                }
                            }
                        }
                        return null;
                    });
                    if (coordinates is object)
                    {
                        return input
                            .Clone(new MetadataItems
                            {
                                { SiteKeys.Lat, coordinates.Lat },
                                { SiteKeys.Lon, coordinates.Lon }
                            })
                            .Yield();
                    }
                }
            }
            return input.Yield();
        }

        public class SearchAddressResponse
        {
            public SearchAddressResult[] Results { get; set; }
        }

        public class SearchAddressResult
        {
            public CoordinateAbbreviated Position { get; set; }
        }

        public class CoordinateAbbreviated
        {
            public double Lat { get; set; }
            public double Lon { get; set; }
        }
    }
}
