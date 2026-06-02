using Newtonsoft.Json;

namespace YouTubeSharp.Channels.Models.Request
{
    public class ChannelsListRequest
    {
        /// <summary>
        /// Comma-separated list of channel resource properties to include (e.g., "snippet,statistics,contentDetails,brandingSettings").
        /// </summary>
        [JsonProperty("part")]
        public string Part { get; set; } = "snippet,statistics";

        /// <summary>
        /// Comma-separated list of specific YouTube channel IDs to fetch.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Filters by a legacy YouTube username.
        /// </summary>
        [JsonProperty("forUsername")]
        public string? ForUsername { get; set; }

        /// <summary>
        /// Set to true to instruct the API to only return channels managed by the content owner.
        /// </summary>
        [JsonProperty("managedByMe")]
        public bool? ManagedByMe { get; set; }

        /// <summary>
        /// Set to true to retrieve the authenticated user's channel feed.
        /// </summary>
        [JsonProperty("mine")]
        public bool? Mine { get; set; }

        [JsonProperty("maxResults")]
        public int? MaxResults { get; set; }

        [JsonProperty("pageToken")]
        public string? PageToken { get; set; }

        [JsonProperty("hl")]
        public string? Hl { get; set; }

        [JsonProperty("onBehalfOfContentOwner")]
        public string? OnBehalfOfContentOwner { get; set; }
    }

    public class ChannelsUpdateRequest
    {
        /// <summary>
        /// The part parameter specifies the properties that the API response/update will include (e.g., "brandingSettings,localizations").
        /// </summary>
        [JsonProperty("part")]
        public string Part { get; set; } = "brandingSettings";

        [JsonProperty("onBehalfOfContentOwner")]
        public string? OnBehalfOfContentOwner { get; set; }
    }
}