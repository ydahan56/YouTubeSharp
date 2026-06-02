using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace YouTubeSharp.PlaylistItems.Models.Request;

public class PlaylistItem
{
    [JsonProperty("kind")]
    public string? Kind { get; set; }

    [JsonProperty("etag")]
    public string? Etag { get; set; }

    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("snippet")]
    public Snippet? Snippet { get; set; }

    [JsonProperty("contentDetails")]
    public ContentDetails? ContentDetails { get; set; }

    [JsonProperty("status")]
    public Status? Status { get; set; }
}

public class Snippet
{
    [JsonProperty("publishedAt")]
    public DateTime? PublishedAt { get; set; }

    [JsonProperty("channelId")]
    public string? ChannelId { get; set; }

    [JsonProperty("title")]
    public string? Title { get; set; }

    [JsonProperty("description")]
    public string? Description { get; set; }

    // Both the dictionary wrapper itself and the inner Thumbnail instances are now nullable
    [JsonProperty("thumbnails")]
    public Dictionary<string, Thumbnail?>? Thumbnails { get; set; }

    [JsonProperty("channelTitle")]
    public string? ChannelTitle { get; set; }

    [JsonProperty("videoOwnerChannelTitle")]
    public string? VideoOwnerChannelTitle { get; set; }

    [JsonProperty("videoOwnerChannelId")]
    public string? VideoOwnerChannelId { get; set; }

    [JsonProperty("playlistId")]
    public string? PlaylistId { get; set; }

    [JsonProperty("position")]
    public uint? Position { get; set; }

    [JsonProperty("resourceId")]
    public ResourceId? ResourceId { get; set; }
}

public class Thumbnail
{
    [JsonProperty("url")]
    public string? Url { get; set; }

    [JsonProperty("width")]
    public uint? Width { get; set; }

    [JsonProperty("height")]
    public uint? Height { get; set; }
}

public class ResourceId
{
    [JsonProperty("kind")]
    public string? Kind { get; set; }

    [JsonProperty("videoId")]
    public string? VideoId { get; set; }
}

public class ContentDetails
{
    [JsonProperty("videoId")]
    public string? VideoId { get; set; }

    [JsonProperty("startAt")]
    public string? StartAt { get; set; }

    [JsonProperty("endAt")]
    public string? EndAt { get; set; }

    [JsonProperty("note")]
    public string? Note { get; set; }

    [JsonProperty("videoPublishedAt")]
    public DateTime? VideoPublishedAt { get; set; }
}

public class Status
{
    [JsonProperty("privacyStatus")]
    public string? PrivacyStatus { get; set; }
}