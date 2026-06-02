using System.Collections.Generic;
using Newtonsoft.Json;

namespace YouTubeSharp.VideoAbuseReportReasons.Models.Response
{
    public class Root
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#videoAbuseReportReasonListResponse";

        [JsonProperty("etag")]
        public string Etag { get; set; } = string.Empty;

        [JsonProperty("items")]
        public List<VideoAbuseReportReasonItem> Items { get; set; } = new();
    }

    public class VideoAbuseReportReasonItem
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#videoAbuseReportReason";

        [JsonProperty("etag")]
        public string Etag { get; set; } = string.Empty;

        /// <summary>
        /// The unique ID that YouTube uses to identify this specific reporting reason category.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("snippet")]
        public VideoAbuseReportReasonSnippet? Snippet { get; set; }
    }

    public class VideoAbuseReportReasonSnippet
    {
        /// <summary>
        /// The localized, readable description text of the abuse reason.
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; } = string.Empty;

        /// <summary>
        /// Sub-reasons providing more precise details for this specific reporting category.
        /// </summary>
        [JsonProperty("secondaryReasons")]
        public List<SecondaryReason>? SecondaryReasons { get; set; }
    }

    public class SecondaryReason
    {
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("label")]
        public string Label { get; set; } = string.Empty;
    }
}