using Newtonsoft.Json;

namespace YouTubeSharp.Captions.Models.Response
{
    public class Root
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#captionListResponse";

        [JsonProperty("etag")]
        public string Etag { get; set; } = string.Empty;

        [JsonProperty("items")]
        public List<CaptionItem> Items { get; set; } = new();
    }

    public class CaptionItem
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#caption";

        [JsonProperty("etag")]
        public string Etag { get; set; } = string.Empty;

        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("snippet")]
        public CaptionSnippet? Snippet { get; set; }
    }

    public class CaptionSnippet
    {
        [JsonProperty("videoId")]
        public string VideoId { get; set; } = string.Empty;

        [JsonProperty("lastUpdated")]
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// "standard", "ASR" (auto speech recognition), "forced"
        /// </summary>
        [JsonProperty("trackKind")]
        public string TrackKind { get; set; } = string.Empty;

        [JsonProperty("language")]
        public string Language { get; set; } = string.Empty;

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// "primary", "commentary", "descriptive", "unknown"
        /// </summary>
        [JsonProperty("audioTrackType")]
        public string AudioTrackType { get; set; } = string.Empty;

        [JsonProperty("isCC")]
        public bool IsCC { get; set; }

        [JsonProperty("isLarge")]
        public bool IsLarge { get; set; }

        [JsonProperty("isEasyReader")]
        public bool IsEasyReader { get; set; }

        [JsonProperty("isDraft")]
        public bool IsDraft { get; set; }

        [JsonProperty("isAutoSynced")]
        public bool IsAutoSynced { get; set; }

        /// <summary>
        /// "serving", "syncing", "failed"
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// "unknownFormat", "unsupportedFormat", "processingFailed"
        /// </summary>
        [JsonProperty("failureReason")]
        public string? FailureReason { get; set; }
    }
}