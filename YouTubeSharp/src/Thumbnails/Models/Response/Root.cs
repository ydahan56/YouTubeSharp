using Newtonsoft.Json;

namespace YouTubeSharp.Thumbnails.Models.Response
{
    public class Root
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#thumbnailListResponse";

        [JsonProperty("etag")]
        public string Etag { get; set; } = string.Empty;

        [JsonProperty("items")]
        public List<ThumbnailItem> Items { get; set; } = new();
    }

    public class ThumbnailItem
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
}