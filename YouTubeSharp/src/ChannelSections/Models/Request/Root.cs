using Newtonsoft.Json;

namespace YouTubeSharp.ChannelSections.Models.Request
{
    public class ChannelSectionsListRequest
    {
        [JsonProperty("part")]
        public string Part { get; set; } = "snippet,contentDetails";

        /// <summary>
        /// Filter sections belonging to a specific channel ID.
        /// </summary>
        [JsonProperty("channelId")]
        public string? ChannelId { get; set; }

        /// <summary>
        /// Filter by a specific comma-separated list of ChannelSection IDs.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Set to true to retrieve sections for the authenticated user's channel.
        /// </summary>
        [JsonProperty("mine")]
        public bool? Mine { get; set; }

        [JsonProperty("hl")]
        public string? Hl { get; set; }

        [JsonProperty("onBehalfOfContentOwner")]
        public string? OnBehalfOfContentOwner { get; set; }
    }

    public class ChannelSectionsInsertRequest
    {
        [JsonProperty("part")]
        public string Part { get; set; } = "snippet,contentDetails";

        [JsonProperty("onBehalfOfContentOwner")]
        public string? OnBehalfOfContentOwner { get; set; }
    }

    public class ChannelSectionsUpdateRequest
    {
        [JsonProperty("part")]
        public string Part { get; set; } = "snippet,contentDetails";

        [JsonProperty("onBehalfOfContentOwner")]
        public string? OnBehalfOfContentOwner { get; set; }
    }

    public class ChannelSectionsDeleteRequest
    {
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("onBehalfOfContentOwner")]
        public string? OnBehalfOfContentOwner { get; set; }
    }
}