namespace YouTubeSharp.VideoCategories.Models.Request
{
    public class VideoCategoriesListRequest
    {
        public string? Part { get; set; } = "snippet";
        
        /// <summary>
        /// Comma-separated list of video category IDs to retrieve.
        /// </summary>
        public string? Id { get; set; }
        
        /// <summary>
        /// ISO 3166-1 alpha-2 country code (e.g., US, BR). Required if Id is not specified.
        /// </summary>
        public string? RegionCode { get; set; }
        
        /// <summary>
        /// Language code for localized text (e.g., en_US, es_MX).
        /// </summary>
        public string? Hl { get; set; }
    }
}