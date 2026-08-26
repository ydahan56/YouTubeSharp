using Newtonsoft.Json;

namespace YouTubeSharp.PlaylistImages.Models.Response
{
    public class Root
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#playlistImageListResponse";

        [JsonProperty("etag")]
        public string Etag { get; set; } = string.Empty;

        [JsonProperty("nextPageToken")]
        public string? NextPageToken { get; set; }

        [JsonProperty("prevPageToken")]
        public string? PrevPageToken { get; set; }

        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }

        [JsonProperty("items")]
        public List<PlaylistImageItem> Items { get; set; } = new();
    }

    public class PageInfo
    {
        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("resultsPerPage")]
        public int ResultsPerPage { get; set; }
    }

    public class PlaylistImageItem
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#playlistImage";

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("snippet")]
        public PlaylistImageSnippet? Snippet { get; set; }
    }

    public class PlaylistImageSnippet
    {
        [JsonProperty("playlistId")]
        public string PlaylistId { get; set; } = string.Empty;

        /// <summary>
        /// The image layout style profile type designation (e.g., "hero").
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; } = string.Empty;

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }
    }
}