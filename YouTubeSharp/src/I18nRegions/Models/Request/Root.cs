using Newtonsoft.Json;

namespace YouTubeSharp.I18nRegions.Models.Request
{
    public class I18nRegionsListRequest
    {
        /// <summary>
        /// The part parameter specifies the i18nRegion resource properties that the API response will include. (e.g., "snippet")
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