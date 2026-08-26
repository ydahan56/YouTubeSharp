namespace YouTubeSharp.Watermarks.Models.Request
{
    public class WatermarksSetRequest
    {
        public string? ChannelId { get; set; }
        public string? OnBehalfOfContentOwner { get; set; }

        // Watermark display properties (Timing, Alignment, etc.)
        public WatermarkResource? Resource { get; set; }

        // Binary fields for the file streaming upload
        public byte[]? ImageBytes { get; set; }
        public string? ContentType { get; set; } = "image/png";
        public string? FileName { get; set; } = "watermark.png";
    }

    public class WatermarksUnsetRequest
    {
        public string? ChannelId { get; set; }
        public string? OnBehalfOfContentOwner { get; set; }
    }
}