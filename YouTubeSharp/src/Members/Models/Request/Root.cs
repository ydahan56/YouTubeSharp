using Newtonsoft.Json;

namespace YouTubeSharp.Members.Models.Request
{
    public class MembersListRequest
    {
        /// <summary>
        /// Specifies the properties that the API response will include. (e.g., "snippet")
        /// </summary>
        [JsonProperty("part")]
        public string Part { get; set; } = "snippet";

        /// <summary>
        /// Filters members that have explicit system access to the specified pricing level ID tier.
        /// </summary>
        [JsonProperty("hasAccessToLevel")]
        public string? HasAccessToLevel { get; set; }

        /// <summary>
        /// The maximum number of items that should be returned in the result set (0 to 1000).
        /// </summary>
        [JsonProperty("maxResults")]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Determines which membership logs to extract: "all" (default) or "updates".
        /// </summary>
        [JsonProperty("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// The token to retrieve a specific page in the paginated result set.
        /// </summary>
        [JsonProperty("pageToken")]
        public string? PageToken { get; set; }
    }
}