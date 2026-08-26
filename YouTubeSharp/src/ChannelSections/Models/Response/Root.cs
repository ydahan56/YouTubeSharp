using Newtonsoft.Json;

namespace YouTubeSharp.ChannelSections.Models.Response
{
    public class Root
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#channelSectionListResponse";

        [JsonProperty("etag")]
        public string Etag { get; set; } = string.Empty;

        [JsonProperty("items")]
        public List<ChannelSectionItem> Items { get; set; } = new();
    }

    public class ChannelSectionItem
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#channelSection";

        [JsonProperty("etag")]
        public string Etag { get; set; } = string.Empty;

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("snippet")]
        public ChannelSectionSnippet? Snippet { get; set; }

        [JsonProperty("contentDetails")]
        public ChannelSectionContentDetails? ContentDetails { get; set; }
    }

    public class ChannelSectionSnippet
    {
        [JsonProperty("channelId")]
        public string? ChannelId { get; set; }

        /// <summary>
        /// Type of section: "allPlaylists", "completedEvents", "likedVideos", "likes", 
        /// "liveEvents", "multipleChannels", "multiplePlaylists", "popularUploads", 
        /// "recentUploads", "singlePlaylist", "subscriptions", "upcomingEvents"
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// Visual layout: "horizontalRow" or "verticalList"
        /// </summary>
        [JsonProperty("style")]
        public string? Style { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("position")]
        public int? Position { get; set; }

        [JsonProperty("defaultLanguage")]
        public string? DefaultLanguage { get; set; }

        [JsonProperty("localized")]
        public LocalizedTitle? Localized { get; set; }
    }

    public class LocalizedTitle
    {
        [JsonProperty("title")]
        public string Title { get; set; } = string.Empty;
    }

    public class ChannelSectionContentDetails
    {
        /// <summary>
        /// Set of playlist IDs associated with this section (populated if type is singlePlaylist or multiplePlaylists).
        /// </summary>
        [JsonProperty("playlists")]
        public List<string>? Playlists { get; set; }

        /// <summary>
        /// Set of channel IDs associated with this section (populated if type is multipleChannels).
        /// </summary>
        [JsonProperty("channels")]
        public List<string>? Channels { get; set; }
    }
}