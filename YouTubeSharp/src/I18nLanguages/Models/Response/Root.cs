using Newtonsoft.Json;

namespace YouTubeSharp.I18nLanguages.Models.Response
{
    public class Root
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#i18nLanguageListResponse";

        [JsonProperty("etag")]
        public string Etag { get; set; } = string.Empty;

        [JsonProperty("items")]
        public List<I18nLanguageItem> Items { get; set; } = new();
    }

    public class I18nLanguageItem
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#i18nLanguage";

        [JsonProperty("etag")]
        public string Etag { get; set; } = string.Empty;

        /// <summary>
        /// The unique ID that YouTube uses to identify this language (e.g., "en", "es").
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("snippet")]
        public I18nLanguageSnippet? Snippet { get; set; }
    }

    public class I18nLanguageSnippet
    {
        /// <summary>
        /// A short BCP-47/ISO-639-1 code identifier string.
        /// </summary>
        [JsonProperty("hl")]
        public string Hl { get; set; } = string.Empty;

        /// <summary>
        /// The readable name of the language (e.g., "English", "Español").
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;
    }
}