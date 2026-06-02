using Newtonsoft.Json;

namespace YouTubeSharp.VideoAbuseReportReasons.Models.Request
{
    public class VideoAbuseReportReasonsListRequest
    {
        /// <summary>
        /// Specifies the videoAbuseReportReason properties that the response will include. (e.g., "snippet")
        /// </summary>
        [JsonProperty("part")]
        public string Part { get; set; } = "snippet";

        /// <summary>
        /// Specifies the language that should be used for text values in the API response.
        /// </summary>
        [JsonProperty("hl")]
        public string? Hl { get; set; }
    }
}