using Newtonsoft.Json;

namespace YouTubeSharp.CommentThreads.Models.Request
{
    public class CommentThreadsListRequest
    {
        [JsonProperty("part")]
        public string Part { get; set; } = "snippet,replies";

        /// <summary>
        /// Returns all threads associated with a channel, including video comments.
        /// </summary>
        [JsonProperty("allThreadsRelatedToChannelId")]
        public string? AllThreadsRelatedToChannelId { get; set; }

        /// <summary>
        /// Returns threads directly on a channel's homepage (does not include video comments).
        /// </summary>
        [JsonProperty("channelId")]
        public string? ChannelId { get; set; }

        /// <summary>
        /// Comma-separated list of specific comment thread IDs to fetch.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Returns all comment threads for a specific video ID.
        /// </summary>
        [JsonProperty("videoId")]
        public string? VideoId { get; set; }

        [JsonProperty("maxResults")]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Filter by moderation state: "all", "heldForReview", or "published" (default)
        /// </summary>
        [JsonProperty("moderationStatus")]
        public string? ModerationStatus { get; set; }

        /// <summary>
        /// Sorting order: "time" (default) or "relevance"
        /// </summary>
        [JsonProperty("order")]
        public string? Order { get; set; }

        [JsonProperty("pageToken")]
        public string? PageToken { get; set; }

        /// <summary>
        /// Limits results to threads containing these specific keywords.
        /// </summary>
        [JsonProperty("searchTerms")]
        public string? SearchTerms { get; set; }

        /// <summary>
        /// Output text format profile: "html" or "plainText"
        /// </summary>
        [JsonProperty("textFormat")]
        public string? TextFormat { get; set; }
    }

    public class CommentThreadsInsertRequest
    {
        [JsonProperty("part")]
        public string Part { get; set; } = "snippet";
    }
}