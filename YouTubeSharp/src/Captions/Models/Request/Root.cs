using Newtonsoft.Json;

namespace YouTubeSharp.Captions.Models.Request
{
    // Query parameters for listing captions
    public class CaptionsListRequest
    {
        [JsonProperty("part")]
        public string Part { get; set; } = "snippet";

        [JsonProperty("videoId")]
        public string VideoId { get; set; } = string.Empty;

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("onBehalfOfContentOwner")]
        public string? OnBehalfOfContentOwner { get; set; }
    }

    // Query parameters for inserting captions
    public class CaptionsInsertRequest
    {
        [JsonProperty("part")]
        public string Part { get; set; } = "snippet";

        [JsonProperty("onBehalfOfContentOwner")]
        public string? OnBehalfOfContentOwner { get; set; }
    }

    // Query parameters for updating captions
    public class CaptionsUpdateRequest
    {
        [JsonProperty("part")]
        public string Part { get; set; } = "snippet";

        [JsonProperty("onBehalfOfContentOwner")]
        public string? OnBehalfOfContentOwner { get; set; }
    }

    // Query parameters for downloading caption tracks
    public class CaptionsDownloadRequest
    {
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Output format: "srt", "vtt", etc.
        /// </summary>
        [JsonProperty("tfmt")]
        public string? Tfmt { get; set; }

        /// <summary>
        /// Request a machine translation into this ISO 639-1 language code.
        /// </summary>
        [JsonProperty("tlang")]
        public string? Tlang { get; set; }

        [JsonProperty("onBehalfOfContentOwner")]
        public string? OnBehalfOfContentOwner { get; set; }
    }

    // Query parameters for deleting captions
    public class CaptionsDeleteRequest
    {
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("onBehalfOfContentOwner")]
        public string? OnBehalfOfContentOwner { get; set; }
    }

    // JSON Body payload metadata used for Insert and Update operations
    public class CaptionResourceRequest
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("snippet")]
        public CaptionSnippetRequest? Snippet { get; set; }
    }

    public class CaptionSnippetRequest
    {
        [JsonProperty("videoId")]
        public string VideoId { get; set; } = string.Empty;

        [JsonProperty("language")]
        public string Language { get; set; } = string.Empty;

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("isDraft")]
        public bool? IsDraft { get; set; }
    }
}