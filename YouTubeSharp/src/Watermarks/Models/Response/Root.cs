using Newtonsoft.Json;

namespace YouTubeSharp.Watermarks.Models
{
    public class WatermarkResource
    {
        [JsonProperty("timing")]
        public TimingSettings? Timing { get; set; }

        [JsonProperty("position")]
        public PositionSettings? Position { get; set; }

        [JsonProperty("targetChannelId")]
        public string? TargetChannelId { get; set; }
    }

    public class TimingSettings
    {
        /// <summary>
        /// Valid values: "offsetFromStart" or "offsetFromEnd"
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("offsetMs")]
        public ulong? OffsetMs { get; set; }

        [JsonProperty("durationMs")]
        public ulong? DurationMs { get; set; }
    }

    public class PositionSettings
    {
        /// <summary>
        /// Valid value: "corner"
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; } = "corner";

        /// <summary>
        /// Valid value: "topRight"
        /// </summary>
        [JsonProperty("cornerPosition")]
        public string? CornerPosition { get; set; } = "topRight";
    }
}