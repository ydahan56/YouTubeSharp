using Newtonsoft.Json;

namespace YouTubeSharp.MembershipsLevels.Models.Request
{
    public class MembershipsLevelsListRequest
    {
        /// <summary>
        /// Specifies the properties that the API response will include. (e.g., "id,snippet")
        /// </summary>
        [JsonProperty("part")]
        public string Part { get; set; } = "snippet";

        /// <summary>
        /// The hl parameter specifies the language that should be used for text values in the API response.
        /// </summary>
        [JsonProperty("hl")]
        public string? Hl { get; set; }
    }
}