using Newtonsoft.Json;

namespace YouTubeSharp.Search.Models.Request
{
    public class Root
    {
        [JsonProperty("kind")]
        public string? Kind { get; set; } = "youtube#search";

        [JsonProperty("etag")]
        public string? Etag { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("snippet")]
        public Snippet? Snippet { get; set; }

        [JsonProperty("contentDetails")]
        public ContentDetails? ContentDetails { get; set; }

        [JsonProperty("status")]
        public Status? Status { get; set; }
    }

    public class Snippet
    {
        [JsonProperty("playlistId")]
        public string? PlaylistId { get; set; }

        [JsonProperty("position")]
        public int? Position { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("resourceId")]
        public ResourceId? ResourceId { get; set; }

        [JsonProperty("channelId")]
        public string? ChannelId { get; set; }

        [JsonProperty("channelTitle")]
        public string? ChannelTitle { get; set; }

        [JsonProperty("thumbnails")]
        public System.Collections.Generic.Dictionary<string, Thumbnail>? Thumbnails { get; set; }
    }

    public class ResourceId
    {
        [JsonProperty("kind")]
        public string? Kind { get; set; } = "youtube#video";

        [JsonProperty("videoId")]
        public string? VideoId { get; set; }
    }

    public class Thumbnail
    {
        [JsonProperty("url")]
        public string? Url { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }
    }

    public class ContentDetails
    {
        [JsonProperty("videoId")]
        public string? VideoId { get; set; }

        [JsonProperty("note")]
        public string? Note { get; set; }

        [JsonProperty("startAt")]
        public string? StartAt { get; set; }

        [JsonProperty("endAt")]
        public string? EndAt { get; set; }

        [JsonProperty("videoPublishedAt")]
        public DateTime? VideoPublishedAt { get; set; }
    }

    public class Status
    {
        [JsonProperty("privacyStatus")]
        public string? PrivacyStatus { get; set; }
    }
}