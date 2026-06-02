using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace YouTubeSharp.Search.Models.Response
{

    public class Root
    {
        [JsonPropertyName("kind")]
        public string? Kind { get; set; }

        [JsonPropertyName("etag")]
        public string? Etag { get; set; }

        [JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        [JsonPropertyName("prevPageToken")]
        public string? PrevPageToken { get; set; }

        [JsonPropertyName("regionCode")]
        public string? RegionCode { get; set; }

        [JsonPropertyName("pageInfo")]
        public PageInfo? PageInfo { get; set; }

        [JsonPropertyName("items")]
        public List<SearchResult>? Items { get; set; }
    }

    public class PageInfo
    {
        [JsonPropertyName("totalResults")]
        public int? TotalResults { get; set; }

        [JsonPropertyName("resultsPerPage")]
        public int? ResultsPerPage { get; set; }
    }

    public class SearchResult
    {
        [JsonPropertyName("kind")]
        public string? Kind { get; set; }

        [JsonPropertyName("etag")]
        public string? Etag { get; set; }

        [JsonPropertyName("id")]
        public SearchResultId? Id { get; set; }

        [JsonPropertyName("snippet")]
        public SearchResultSnippet? Snippet { get; set; }
    }

    public class SearchResultId
    {
        [JsonPropertyName("kind")]
        public string? Kind { get; set; }

        // Note: In a search result, only one of these three IDs will typically be populated 
        // depending on whether the 'kind' is a video, channel, or playlist.
        [JsonPropertyName("videoId")]
        public string? VideoId { get; set; }

        [JsonPropertyName("channelId")]
        public string? ChannelId { get; set; }

        [JsonPropertyName("playlistId")]
        public string? PlaylistId { get; set; }
    }

    public class SearchResultSnippet
    {
        [JsonPropertyName("publishedAt")]
        public DateTime? PublishedAt { get; set; }

        [JsonPropertyName("channelId")]
        public string? ChannelId { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("thumbnails")]
        public Dictionary<string, Thumbnail>? Thumbnails { get; set; }

        [JsonPropertyName("channelTitle")]
        public string? ChannelTitle { get; set; }

        [JsonPropertyName("liveBroadcastContent")]
        public string? LiveBroadcastContent { get; set; }
    }

    // You can safely remove this class if you are already using 
    // the Thumbnail class from the PlaylistItem model!
    public class Thumbnail
    {
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("width")]
        public uint? Width { get; set; }

        [JsonPropertyName("height")]
        public uint? Height { get; set; }
    }
}
