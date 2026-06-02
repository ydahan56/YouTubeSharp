using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace YouTubeSharp.Videos.Models.Response
{
    public class VideoListResponse
    {
        [JsonProperty("kind")]
        public string? Kind { get; set; } = "youtube#videoListResponse";

        [JsonProperty("etag")]
        public string? Etag { get; set; }

        [JsonProperty("nextPageToken")]
        public string? NextPageToken { get; set; }

        [JsonProperty("prevPageToken")]
        public string? PrevPageToken { get; set; }

        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }

        [JsonProperty("items")]
        public List<Video>? Items { get; set; } = new();
    }

    public class PageInfo
    {
        [JsonProperty("totalResults")]
        public int? TotalResults { get; set; }

        [JsonProperty("resultsPerPage")]
        public int? ResultsPerPage { get; set; }
    }

    public class Video
    {
        [JsonProperty("kind")]
        public string? Kind { get; set; } = "youtube#video";

        [JsonProperty("etag")]
        public string? Etag { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("snippet")]
        public VideoSnippet? Snippet { get; set; }

        [JsonProperty("contentDetails")]
        public VideoContentDetails? ContentDetails { get; set; }

        [JsonProperty("status")]
        public VideoStatus? Status { get; set; }

        [JsonProperty("statistics")]
        public VideoStatistics? Statistics { get; set; }
    }

    public class VideoSnippet
    {
        [JsonProperty("publishedAt")]
        public DateTime? PublishedAt { get; set; }

        [JsonProperty("channelId")]
        public string? ChannelId { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("thumbnails")]
        public ThumbnailDetails? Thumbnails { get; set; }

        [JsonProperty("channelTitle")]
        public string? ChannelTitle { get; set; }

        [JsonProperty("tags")]
        public List<string>? Tags { get; set; } = new();

        [JsonProperty("categoryId")]
        public string? CategoryId { get; set; }

        [JsonProperty("liveBroadcastContent")]
        public string? LiveBroadcastContent { get; set; }

        [JsonProperty("defaultLanguage")]
        public string? DefaultLanguage { get; set; }

        [JsonProperty("defaultAudioLanguage")]
        public string? DefaultAudioLanguage { get; set; }
    }

    public class ThumbnailDetails
    {
        [JsonProperty("default")]
        public Thumbnail? Default { get; set; }

        [JsonProperty("medium")]
        public Thumbnail? Medium { get; set; }

        [JsonProperty("high")]
        public Thumbnail? High { get; set; }

        [JsonProperty("standard")]
        public Thumbnail? Standard { get; set; }

        [JsonProperty("maxres")]
        public Thumbnail? Maxres { get; set; }
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

    public class VideoContentDetails
    {
        [JsonProperty("duration")]
        public string? Duration { get; set; } // ISO 8601 Duration string (e.g., PT15M33S)

        [JsonProperty("dimension")]
        public string? Dimension { get; set; }

        [JsonProperty("definition")]
        public string? Definition { get; set; } // "hd" or "sd"

        [JsonProperty("caption")]
        public string? Caption { get; set; } // "true" or "false"

        [JsonProperty("licensedContent")]
        public bool? LicensedContent { get; set; }

        [JsonProperty("projection")]
        public string? Projection { get; set; } // "rectangular" or "360"
    }

    public class VideoStatus
    {
        [JsonProperty("uploadStatus")]
        public string? UploadStatus { get; set; }

        [JsonProperty("privacyStatus")]
        public string? PrivacyStatus { get; set; } // "public", "private", or "unlisted"

        [JsonProperty("license")]
        public string? License { get; set; }

        [JsonProperty("embeddable")]
        public bool? Embeddable { get; set; }

        [JsonProperty("publicStatsViewable")]
        public bool? PublicStatsViewable { get; set; }

        [JsonProperty("madeForKids")]
        public bool? MadeForKids { get; set; }
    }

    public class VideoStatistics
    {
        [JsonProperty("viewCount")]
        public ulong? ViewCount { get; set; }

        [JsonProperty("likeCount")]
        public ulong? LikeCount { get; set; }

        [JsonProperty("dislikeCount")]
        public ulong? DislikeCount { get; set; } // Deprecated by YouTube but still present in API contract

        [JsonProperty("favoriteCount")]
        public ulong? FavoriteCount { get; set; }

        [JsonProperty("commentCount")]
        public ulong? CommentCount { get; set; }
    }
}