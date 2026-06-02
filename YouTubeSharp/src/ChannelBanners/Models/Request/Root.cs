using Newtonsoft.Json;

namespace YouTubeSharp.ChannelBanners.Models.Request
{
    public class ChannelBannersInsertRequest
    {
        /// <summary>
        /// Identifies the unique YouTube channel ID to which the banner is being uploaded.
        /// </summary>
        [JsonProperty("channelId")]
        public string? ChannelId { get; set; }

        /// <summary>
        /// Note: This parameter is intended exclusively for authorized YouTube content partners.
        /// </summary>
        [JsonProperty("onBehalfOfContentOwner")]
        public string? OnBehalfOfContentOwner { get; set; }
    }
}