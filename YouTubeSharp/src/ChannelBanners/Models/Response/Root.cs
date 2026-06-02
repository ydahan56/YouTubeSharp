using Newtonsoft.Json;

namespace YouTubeSharp.ChannelBanners.Models.Response
{
    public class ChannelBannerResource
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#channelBannerResource";

        [JsonProperty("etag")]
        public string Etag { get; set; } = string.Empty;

        /// <summary>
        /// The short-lived unique banner image URL.
        /// Pass this string directly into a channels.update call to save changes.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; } = string.Empty;
    }
}