using YouTubeSharp.Videos.Models.Response;

namespace YouTubeSharp.Videos.Models.Request
{
    public class VideosListRequest
    {
        public string? Part { get; set; } = "snippet,contentDetails,statistics,status";
        public string? Id { get; set; }
        public string? Chart { get; set; } // e.g., "mostPopular"
        public uint? MaxResults { get; set; }
        public string? PageToken { get; set; }
        public string? RegionCode { get; set; }
        public string? VideoCategoryId { get; set; }
        public string? MyRating { get; set; } // "like" or "dislike"
    }

    public class VideosInsertRequest
    {
        public string? Part { get; set; } = "snippet,status";
        public bool? NotifySubscribers { get; set; } = true;
        public Video? Resource { get; set; }

        // Binary Payload properties
        public byte[]? VideoBytes { get; set; }
        public string? ContentType { get; set; } = "video/mp4";
        public string? FileName { get; set; } = "video.mp4";
    }

    public class VideosUpdateRequest
    {
        public string? Part { get; set; } = "snippet,status";
        public Video? Resource { get; set; }
    }

    public class VideosDeleteRequest
    {
        public string? Id { get; set; }
    }
}