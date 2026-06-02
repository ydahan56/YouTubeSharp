using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace YouTubeSharp.Subscriptions.Models.Response
{
    public class Root
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#subscriptionListResponse";

        [JsonProperty("etag")]
        public string Etag { get; set; } = string.Empty;

        [JsonProperty("nextPageToken")]
        public string? NextPageToken { get; set; }

        [JsonProperty("prevPageToken")]
        public string? PrevPageToken { get; set; }

        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }

        [JsonProperty("items")]
        public List<SubscriptionItem> Items { get; set; } = new();
    }

    public class PageInfo
    {
        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("resultsPerPage")]
        public int ResultsPerPage { get; set; }
    }

    public class SubscriptionItem
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#subscription";

        [JsonProperty("etag")]
        public string Etag { get; set; } = string.Empty;

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("snippet")]
        public SubscriptionSnippet? Snippet { get; set; }

        [JsonProperty("contentDetails")]
        public SubscriptionContentDetails? ContentDetails { get; set; }

        [JsonProperty("subscriberSnippet")]
        public SubscriberSnippet? SubscriberSnippet { get; set; }
    }

    public class SubscriptionSnippet
    {
        [JsonProperty("publishedAt")]
        public DateTime PublishedAt { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; } = string.Empty;

        [JsonProperty("description")]
        public string Description { get; set; } = string.Empty;

        [JsonProperty("resourceId")]
        public ResourceId? ResourceId { get; set; }

        [JsonProperty("channelId")]
        public string ChannelId { get; set; } = string.Empty;

        [JsonProperty("channelTitle")]
        public string ChannelTitle { get; set; } = string.Empty;

        [JsonProperty("thumbnails")]
        public ThumbnailResolutionOptions? Thumbnails { get; set; }
    }

    public class ResourceId
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#channel";

        [JsonProperty("channelId")]
        public string ChannelId { get; set; } = string.Empty;
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
    }

    public class SubscriptionContentDetails
    {
        [JsonProperty("totalItemCount")]
        public uint TotalItemCount { get; set; }

        [JsonProperty("newItemCount")]
        public uint NewItemCount { get; set; }

        [JsonProperty("activityType")]
        public string ActivityType { get; set; } = string.Empty;
    }

    public class SubscriberSnippet
    {
        [JsonProperty("title")]
        public string Title { get; set; } = string.Empty;

        [JsonProperty("description")]
        public string Description { get; set; } = string.Empty;

        [JsonProperty("channelId")]
        public string ChannelId { get; set; } = string.Empty;

        [JsonProperty("thumbnails")]
        public ThumbnailResolutionOptions? Thumbnails { get; set; }
    }
}