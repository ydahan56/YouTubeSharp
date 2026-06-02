using Newtonsoft.Json;

namespace YouTubeSharp.Comments.Models.Request
{
    public class CommentsListRequest
    {
        [JsonProperty("part")]
        public string Part { get; set; } = "snippet";

        /// <summary>
        /// Comma-separated list of specific comment IDs to fetch.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The ID of the parent comment for which replies should be retrieved.
        /// </summary>
        [JsonProperty("parentId")]
        public string? ParentId { get; set; }

        [JsonProperty("maxResults")]
        public int? MaxResults { get; set; }

        [JsonProperty("pageToken")]
        public string? PageToken { get; set; }

        /// <summary>
        /// Output text format profile: "html" or "plainText"
        /// </summary>
        [JsonProperty("textFormat")]
        public string? TextFormat { get; set; }
    }

    public class CommentsInsertRequest
    {
        [JsonProperty("part")]
        public string Part { get; set; } = "snippet";
    }

    public class CommentsUpdateRequest
    {
        [JsonProperty("part")]
        public string Part { get; set; } = "snippet";
    }

    public class CommentsDeleteRequest
    {
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;
    }

    public class CommentsSetModerationStatusRequest
    {
        /// <summary>
        /// Comma-separated list of comment IDs whose moderation states are being updated.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Target status: "heldForReview", "published", or "rejected"
        /// </summary>
        [JsonProperty("moderationStatus")]
        public string ModerationStatus { get; set; } = string.Empty;

        /// <summary>
        /// Set to true to ban the author of the comment from making future comments on the channel.
        /// </summary>
        [JsonProperty("banAuthor")]
        public bool? BanAuthor { get; set; }
    }
}