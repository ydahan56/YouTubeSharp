using System.Text.Json.Serialization;

namespace YouTubeSharp.PlaylistItems.Models.Response
{
    public class Root
    {
        [JsonPropertyName("kind")]
        public string? Kind { get; set; }

        [JsonPropertyName("etag")]
        public string? Etag { get; set; }

        [JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        [JsonPropertyName("prevPageToken")]
        public string? PrevPageToken { get; set; }

        [JsonPropertyName("regionCode")]
        public string? RegionCode { get; set; }

        [JsonPropertyName("pageInfo")]
        public PageInfo? PageInfo { get; set; }

        // Both the list wrapper and the containing playlist items are marked nullable
        [JsonPropertyName("items")]
        public List<Request.PlaylistItem?>? Items { get; set; }
    }

    public class PageInfo
    {
        [JsonPropertyName("totalResults")]
        public int? TotalResults { get; set; }

        [JsonPropertyName("resultsPerPage")]
        public int? ResultsPerPage { get; set; }
    }
}