using Newtonsoft.Json;

namespace YouTubeSharp.I18nRegions.Models.Response
{
    public class Root
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#i18nRegionListResponse";

        [JsonProperty("etag")]
        public string Etag { get; set; } = string.Empty;

        [JsonProperty("items")]
        public List<I18nRegionItem> Items { get; set; } = new();
    }

    public class I18nRegionItem
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#i18nRegion";

        [JsonProperty("etag")]
        public string Etag { get; set; } = string.Empty;

        /// <summary>
        /// The unique ID that YouTube uses to identify this region (e.g., "US", "BR", "FR").
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("snippet")]
        public I18nRegionSnippet? Snippet { get; set; }
    }

    public class I18nRegionSnippet
    {
        /// <summary>
        /// A two-letter ISO 3166-1 alpha-2 country code.
        /// </summary>
        [JsonProperty("gl")]
        public string Gl { get; set; } = string.Empty;

        /// <summary>
        /// The readable name of the region (e.g., "United States", "Brazil").
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;
    }
}