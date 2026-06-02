using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace YouTubeSharp.Playlists.Models.Response
{
    public class Root
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#playlistListResponse";

        [JsonProperty("etag")]
        public string Etag { get; set; } = string.Empty;

        [JsonProperty("nextPageToken")]
        public string? NextPageToken { get; set; }

        [JsonProperty("prevPageToken")]
        public string? PrevPageToken { get; set; }

        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }

        [JsonProperty("items")]
        public List<PlaylistItem> Items { get; set; } = new();
    }

    public class PageInfo
    {
        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("resultsPerPage")]
        public int ResultsPerPage { get; set; }
    }

    public class PlaylistItem
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#playlist";

        [JsonProperty("etag")]
        public string Etag { get; set; } = string.Empty;

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("snippet")]
        public PlaylistSnippet? Snippet { get; set; }

        [JsonProperty("status")]
        public PlaylistStatus? Status { get; set; }

        [JsonProperty("contentDetails")]
        public PlaylistContentDetails? ContentDetails { get; set; }

        [JsonProperty("player")]
        public PlaylistPlayer? Player { get; set; }
    }

    public class PlaylistSnippet
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

        [JsonProperty("defaultLanguage")]
        public string? DefaultLanguage { get; set; }

        [JsonProperty("localized")]
        public LocalizedTitle? Localized { get; set; }
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
        public ThumbnailDetails? Maxres { get; set; }
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

    public class LocalizedTitle
    {
        [JsonProperty("title")]
        public string Title { get; set; } = string.Empty;

        [JsonProperty("description")]
        public string Description { get; set; } = string.Empty;
    }

    public class PlaylistStatus
    {
        /// <summary>
        /// The playlist's privacy status: "private", "public", or "unlisted".
        /// </summary>
        [JsonProperty("privacyStatus")]
        public string PrivacyStatus { get; set; } = "private";
    }

    public class PlaylistContentDetails
    {
        /// <summary>
        /// The total number of videos currently contained in the playlist.
        /// </summary>
        [JsonProperty("itemCount")]
        public uint ItemCount { get; set; }
    }

    public class PlaylistPlayer
    {
        /// <summary>
        /// An <iframe> tag that embeds a player that will play the playlist.
        /// </summary>
        [JsonProperty("embedHtml")]
        public string EmbedHtml { get; set; } = string.Empty;
    }
}