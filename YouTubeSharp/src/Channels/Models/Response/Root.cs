using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace YouTubeSharp.Channels.Models.Response
{
    public class Root
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#channelListResponse";

        [JsonProperty("etag")]
        public string Etag { get; set; } = string.Empty;

        [JsonProperty("nextPageToken")]
        public string? NextPageToken { get; set; }

        [JsonProperty("prevPageToken")]
        public string? PrevPageToken { get; set; }

        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }

        [JsonProperty("items")]
        public List<ChannelItem> Items { get; set; } = new();
    }

    public class PageInfo
    {
        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("resultsPerPage")]
        public int ResultsPerPage { get; set; }
    }

    public class ChannelItem
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#channel";

        [JsonProperty("etag")]
        public string Etag { get; set; } = string.Empty;

        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("snippet")]
        public ChannelSnippet? Snippet { get; set; }

        [JsonProperty("contentDetails")]
        public ChannelContentDetails? ContentDetails { get; set; }

        [JsonProperty("statistics")]
        public ChannelStatistics? Statistics { get; set; }

        [JsonProperty("status")]
        public ChannelStatus? Status { get; set; }

        [JsonProperty("brandingSettings")]
        public ChannelBrandingSettings? BrandingSettings { get; set; }
    }

    public class ChannelSnippet
    {
        [JsonProperty("title")]
        public string Title { get; set; } = string.Empty;

        [JsonProperty("description")]
        public string Description { get; set; } = string.Empty;

        [JsonProperty("customUrl")]
        public string? CustomUrl { get; set; }

        [JsonProperty("publishedAt")]
        public DateTime PublishedAt { get; set; }

        [JsonProperty("thumbnails")]
        public ThumbnailResolutionOptions? Thumbnails { get; set; }

        [JsonProperty("defaultLanguage")]
        public string? DefaultLanguage { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }
    }

    public class ThumbnailResolutionOptions
    {
        [JsonProperty("default")]
        public ThumbnailDetails? Default { get; set; }

        [JsonProperty("medium")]
        public ThumbnailDetails? Medium { get; set; }

        [JsonProperty("high")]
        public ThumbnailDetails? High { get; set; }
    }

    public class ThumbnailDetails
    {
        [JsonProperty("url")]
        public string Url { get; set; } = string.Empty;

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }
    }

    public class ChannelContentDetails
    {
        [JsonProperty("relatedPlaylists")]
        public RelatedPlaylists? RelatedPlaylists { get; set; }
    }

    public class RelatedPlaylists
    {
        [JsonProperty("likes")]
        public string? Likes { get; set; }

        [JsonProperty("uploads")]
        public string? Uploads { get; set; }
    }

    public class ChannelStatistics
    {
        [JsonProperty("viewCount")]
        public ulong ViewCount { get; set; }

        [JsonProperty("subscriberCount")]
        public ulong SubscriberCount { get; set; }

        [JsonProperty("hiddenSubscriberCount")]
        public bool HiddenSubscriberCount { get; set; }

        [JsonProperty("videoCount")]
        public ulong VideoCount { get; set; }
    }

    public class ChannelStatus
    {
        [JsonProperty("privacyStatus")]
        public string PrivacyStatus { get; set; } = string.Empty;

        [JsonProperty("isLinked")]
        public bool IsLinked { get; set; }

        [JsonProperty("longUploadsStatus")]
        public string? LongUploadsStatus { get; set; }

        [JsonProperty("madeForKids")]
        public bool? MadeForKids { get; set; }
    }

    public class ChannelBrandingSettings
    {
        [JsonProperty("channel")]
        public ChannelSettingsData? Channel { get; set; }

        [JsonProperty("image")]
        public ImageSettingsData? Image { get; set; }
    }

    public class ChannelSettingsData
    {
        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("keywords")]
        public string? Keywords { get; set; }

        [JsonProperty("trackingAnalyticsAccountId")]
        public string? TrackingAnalyticsAccountId { get; set; }

        [JsonProperty("unsubscribedTrailer")]
        public string? UnsubscribedTrailer { get; set; }

        [JsonProperty("defaultLanguage")]
        public string? DefaultLanguage { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }
    }

    public class ImageSettingsData
    {
        [JsonProperty("bannerExternalUrl")]
        public string? BannerExternalUrl { get; set; }
    }
}