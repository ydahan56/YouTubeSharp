using Newtonsoft.Json;

namespace YouTubeSharp.Subscriptions.Models.Request
{
    public class SubscriptionsListRequest
    {
        [JsonProperty("part")]
        public string Part { get; set; } = "snippet,contentDetails";

        /// <summary>
        /// Returns subscriptions of the specified channel ID.
        /// </summary>
        [JsonProperty("channelId")]
        public string? ChannelId { get; set; }

        /// <summary>
        /// Comma-separated list of specific subscription IDs to fetch.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Set to true to retrieve subscriptions for the authenticated user.
        /// </summary>
        [JsonProperty("mine")]
        public bool? Mine { get; set; }

        /// <summary>
        /// Set to true to retrieve subscribers of the authenticated user's channel.
        /// </summary>
        [JsonProperty("mySubscribers")]
        public bool? MySubscribers { get; set; }

        /// <summary>
        /// Restricts the list to a specific channel subscription state check.
        /// </summary>
        [JsonProperty("forChannelId")]
        public string? ForChannelId { get; set; }

        [JsonProperty("maxResults")]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Order results by: "alphabetical", "relevance", or "subscriberCount".
        /// </summary>
        [JsonProperty("order")]
        public string? Order { get; set; }

        [JsonProperty("pageToken")]
        public string? PageToken { get; set; }
    }

    public class SubscriptionsInsertRequest
    {
        [JsonProperty("part")]
        public string Part { get; set; } = "snippet";
    }

    public class SubscriptionsDeleteRequest
    {
        /// <summary>
        /// The unique subscription ID to delete (unsubscribes the user).
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;
    }
}