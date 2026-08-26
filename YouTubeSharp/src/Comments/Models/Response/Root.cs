using Newtonsoft.Json;

namespace YouTubeSharp.Comments.Models.Response
{
    public class Root
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#commentListResponse";

        [JsonProperty("etag")]
        public string Etag { get; set; } = string.Empty;

        [JsonProperty("nextPageToken")]
        public string? NextPageToken { get; set; }

        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }

        [JsonProperty("items")]
        public List<CommentItem> Items { get; set; } = new();
    }

    public class PageInfo
    {
        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("resultsPerPage")]
        public int ResultsPerPage { get; set; }
    }

    public class CommentItem
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#comment";

        [JsonProperty("etag")]
        public string Etag { get; set; } = string.Empty;

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("snippet")]
        public CommentSnippet? Snippet { get; set; }
    }

    public class CommentSnippet
    {
        [JsonProperty("authorDisplayName")]
        public string AuthorDisplayName { get; set; } = string.Empty;

        [JsonProperty("authorProfileImageUrl")]
        public string AuthorProfileImageUrl { get; set; } = string.Empty;

        [JsonProperty("authorChannelUrl")]
        public string AuthorChannelUrl { get; set; } = string.Empty;

        [JsonProperty("authorChannelId")]
        public AuthorChannelIdContainer? AuthorChannelId { get; set; }

        [JsonProperty("channelId")]
        public string? ChannelId { get; set; }

        [JsonProperty("videoId")]
        public string? VideoId { get; set; }

        [JsonProperty("textDisplay")]
        public string TextDisplay { get; set; } = string.Empty;

        [JsonProperty("textOriginal")]
        public string TextOriginal { get; set; } = string.Empty;

        [JsonProperty("parentId")]
        public string? ParentId { get; set; }

        [JsonProperty("canRate")]
        public bool CanRate { get; set; }

        [JsonProperty("viewerRating")]
        public string ViewerRating { get; set; } = "none"; // "like", "dislike", or "none"

        [JsonProperty("likeCount")]
        public uint LikeCount { get; set; }

        [JsonProperty("publishedAt")]
        public DateTime PublishedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }

    public class AuthorChannelIdContainer
    {
        [JsonProperty("value")]
        public string Value { get; set; } = string.Empty;
    }
}