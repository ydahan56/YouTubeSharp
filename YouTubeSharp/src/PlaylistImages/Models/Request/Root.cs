using Newtonsoft.Json;

namespace YouTubeSharp.PlaylistImages.Models.Request
{
    public class PlaylistImagesListRequest
    {
        [JsonProperty("part")]
        public string Part { get; set; } = "snippet";

        /// <summary>
        /// Comma-separated list of specific playlist image IDs to fetch.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Return the images associated with this specific playlist ID.
        /// </summary>
        [JsonProperty("playlistId")]
        public string? PlaylistId { get; set; }

        [JsonProperty("maxResults")]
        public int? MaxResults { get; set; }

        [JsonProperty("pageToken")]
        public string? PageToken { get; set; }

        [JsonProperty("onBehalfOfContentOwner")]
        public string? OnBehalfOfContentOwner { get; set; }

        [JsonProperty("onBehalfOfContentOwnerChannel")]
        public string? OnBehalfOfContentOwnerChannel { get; set; }
    }

    public class PlaylistImagesInsertRequest
    {
        [JsonProperty("part")]
        public string Part { get; set; } = "snippet";

        [JsonProperty("onBehalfOfContentOwner")]
        public string? OnBehalfOfContentOwner { get; set; }

        [JsonProperty("onBehalfOfContentOwnerChannel")]
        public string? OnBehalfOfContentOwnerChannel { get; set; }
    }

    public class PlaylistImagesUpdateRequest
    {
        [JsonProperty("part")]
        public string Part { get; set; } = "snippet";

        [JsonProperty("onBehalfOfContentOwner")]
        public string? OnBehalfOfContentOwner { get; set; }
    }

    public class PlaylistImagesDeleteRequest
    {
        /// <summary>
        /// The unique ID of the playlist image to be deleted.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("onBehalfOfContentOwner")]
        public string? OnBehalfOfContentOwner { get; set; }
    }
}