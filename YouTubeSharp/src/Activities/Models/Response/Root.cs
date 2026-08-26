using Newtonsoft.Json;

namespace YouTubeSharp.Activities.Models.Response
{
    public class Root
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#activityListResponse";

        [JsonProperty("etag")]
        public string Etag { get; set; } = string.Empty;

        [JsonProperty("nextPageToken")]
        public string? NextPageToken { get; set; }

        [JsonProperty("prevPageToken")]
        public string? PrevPageToken { get; set; }

        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }

        [JsonProperty("items")]
        public List<ActivityItem> Items { get; set; } = new();
    }

    public class PageInfo
    {
        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("resultsPerPage")]
        public int ResultsPerPage { get; set; }
    }

    public class ActivityItem
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#activity";

        [JsonProperty("etag")]
        public string Etag { get; set; } = string.Empty;

        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("snippet")]
        public ActivitySnippet? Snippet { get; set; }

        [JsonProperty("contentDetails")]
        public ActivityContentDetails? ContentDetails { get; set; }
    }

    public class ActivitySnippet
    {
        [JsonProperty("publishedAt")]
        public DateTime PublishedAt { get; set; }

        [JsonProperty("channelId")]
        public string ChannelId { get; set; } = string.Empty;

        [JsonProperty("title")]
        public string Title { get; set; } = string.Empty;

        [JsonProperty("description")]
        public string Description { get; set; } = string.Empty;

        [JsonProperty("thumbnails")]
        public ThumbnailResolutionOptions? Thumbnails { get; set; }

        [JsonProperty("channelTitle")]
        public string ChannelTitle { get; set; } = string.Empty;

        [JsonProperty("type")]
        public string Type { get; set; } = string.Empty;

        [JsonProperty("groupId")]
        public string? GroupId { get; set; }
    }

    public class ThumbnailResolutionOptions
    {
        [JsonProperty("default")]
        public ThumbnailDetails? Default { get; set; }

        [JsonProperty("medium")]
        public ThumbnailDetails? Medium { get; set; }

        [JsonProperty("high")]
        public ThumbnailDetails? High { get; set; }

        [JsonProperty("standard")]
        public ThumbnailDetails? Standard { get; set; }

        [JsonProperty("maxres")]
        public ThumbnailDetails? MaxRes { get; set; }
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

    public class ActivityContentDetails
    {
        [JsonProperty("upload")]
        public UploadDetails? Upload { get; set; }

        [JsonProperty("like")]
        public ResourceDetails? Like { get; set; }

        [JsonProperty("favorite")]
        public ResourceDetails? Favorite { get; set; }

        [JsonProperty("comment")]
        public ResourceDetails? Comment { get; set; }

        [JsonProperty("subscription")]
        public SubscriptionDetails? Subscription { get; set; }

        [JsonProperty("playlistItem")]
        public PlaylistItemDetails? PlaylistItem { get; set; }

        [JsonProperty("recommendation")]
        public RecommendationDetails? Recommendation { get; set; }

        [JsonProperty("bulletin")]
        public BulletinDetails? Bulletin { get; set; }
    }

    public class UploadDetails
    {
        [JsonProperty("videoId")]
        public string VideoId { get; set; } = string.Empty;
    }

    public class ResourceDetails
    {
        [JsonProperty("resourceId")]
        public ResourceId? ResourceId { get; set; }
    }

    public class ResourceId
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = string.Empty;

        [JsonProperty("videoId")]
        public string? VideoId { get; set; }

        [JsonProperty("channelId")]
        public string? ChannelId { get; set; }

        [JsonProperty("playlistId")]
        public string? PlaylistId { get; set; }
    }

    public class SubscriptionDetails
    {
        [JsonProperty("resourceId")]
        public ResourceId? ResourceId { get; set; }
    }

    public class PlaylistItemDetails
    {
        [JsonProperty("resourceId")]
        public ResourceId? ResourceId { get; set; }

        [JsonProperty("playlistItemId")]
        public string PlaylistItemId { get; set; } = string.Empty;
    }

    public class RecommendationDetails
    {
        [JsonProperty("resourceId")]
        public ResourceId? ResourceId { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; } = string.Empty;
    }

    public class BulletinDetails
    {
        [JsonProperty("resourceId")]
        public ResourceId? ResourceId { get; set; }
    }
}