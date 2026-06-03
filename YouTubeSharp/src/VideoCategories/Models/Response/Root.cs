using System.Collections.Generic;
using Newtonsoft.Json;

namespace YouTubeSharp.VideoCategories.Models.Response
{
    public class VideoCategoryListResponse
    {
        [JsonProperty("kind")]
        public string? Kind { get; set; } = "youtube#videoCategoryListResponse";

        [JsonProperty("etag")]
        public string? Etag { get; set; }

        [JsonProperty("items")]
        public List<VideoCategory>? Items { get; set; } = new();
    }

    public class VideoCategory
    {
        [JsonProperty("kind")]
        public string? Kind { get; set; } = "youtube#videoCategory";

        [JsonProperty("etag")]
        public string? Etag { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("snippet")]
        public VideoCategorySnippet? Snippet { get; set; }
    }

    public class VideoCategorySnippet
    {
        /// <summary>
        /// The YouTube Channel ID that owns or manages the global category data.
        /// </summary>
        [JsonProperty("channelId")]
        public string? ChannelId { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Indicates whether videos can be associated with this category via API uploads or edits.
        /// </summary>
        [JsonProperty("assignable")]
        public bool? Assignable { get; set; }
    }
}