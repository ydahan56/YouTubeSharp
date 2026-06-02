using Newtonsoft.Json;

namespace YouTubeSharp.I18nLanguages.Models.Request
{
    public class I18nLanguagesListRequest
    {
        /// <summary>
        /// The part parameter specifies the i18nLanguage resource properties that the API response will include. (e.g., "snippet")
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