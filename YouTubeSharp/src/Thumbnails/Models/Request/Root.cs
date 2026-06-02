using Newtonsoft.Json;

namespace YouTubeSharp.Thumbnails.Models.Request
{
    public class ThumbnailsSetRequest
    {
        /// <summary>
        /// The unique ID of the video for which the custom thumbnail is being uploaded.
        /// </summary>
        [JsonProperty("videoId")]
        public string VideoId { get; set; } = string.Empty;

        [JsonProperty("onBehalfOfContentOwner")]
        public string? OnBehalfOfContentOwner { get; set; }
    }
}