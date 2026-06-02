using System.Collections.Generic;
using Newtonsoft.Json;

namespace YouTubeSharp.MembershipsLevels.Models.Response
{
    public class Root
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#membershipsLevelListResponse";

        [JsonProperty("etag")]
        public string Etag { get; set; } = string.Empty;

        [JsonProperty("items")]
        public List<MembershipsLevelItem> Items { get; set; } = new();
    }

    public class MembershipsLevelItem
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#membershipsLevel";

        [JsonProperty("etag")]
        public string Etag { get; set; } = string.Empty;

        /// <summary>
        /// The unique ID that YouTube assigns to identify this membership level tier.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("snippet")]
        public MembershipsLevelSnippet? Snippet { get; set; }
    }

    public class MembershipsLevelSnippet
    {
        [JsonProperty("creatorChannelId")]
        public string CreatorChannelId { get; set; } = string.Empty;

        [JsonProperty("levelDetails")]
        public LevelDetails? LevelDetails { get; set; }
    }

    public class LevelDetails
    {
        /// <summary>
        /// The public-facing display name configured for this membership tier.
        /// </summary>
        [JsonProperty("displayName")]
        public string DisplayName { get; set; } = string.Empty;
    }
}