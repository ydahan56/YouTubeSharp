using Newtonsoft.Json;

namespace YouTubeSharp.Playlists.Models.Request
{
    public class PlaylistsListRequest
    {
        [JsonProperty("part")]
        public string Part { get; set; } = "snippet,status,contentDetails";

        /// <summary>
        /// Filter playlists owned by this specific channel ID.
        /// </summary>
        [JsonProperty("channelId")]
        public string? ChannelId { get; set; }

        /// <summary>
        /// Comma-separated list of specific Playlist IDs to fetch.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Set to true to retrieve playlists for the authenticated user's channel.
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

        [JsonProperty("onBehalfOfContentOwnerChannel")]
        public string? OnBehalfOfContentOwnerChannel { get; set; }
    }

    public class PlaylistsInsertRequest
    {
        [JsonProperty("part")]
        public string Part { get; set; } = "snippet,status";

        [JsonProperty("onBehalfOfContentOwner")]
        public string? OnBehalfOfContentOwner { get; set; }

        [JsonProperty("onBehalfOfContentOwnerChannel")]
        public string? OnBehalfOfContentOwnerChannel { get; set; }
    }

    public class PlaylistsUpdateRequest
    {
        [JsonProperty("part")]
        public string Part { get; set; } = "snippet,status";

        [JsonProperty("onBehalfOfContentOwner")]
        public string? OnBehalfOfContentOwner { get; set; }
    }

    public class PlaylistsDeleteRequest
    {
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("onBehalfOfContentOwner")]
        public string? OnBehalfOfContentOwner { get; set; }
    }
}