using RestSharp;
using YouTubeSharp.Watermarks.Models.Request;

namespace YouTubeSharp.Watermarks
{
    public interface IWatermarks
    {
        /// <summary>
        /// Uploads a watermark image to YouTube and sets it for a channel.
        /// </summary>
        RestResponse Set(WatermarksSetRequest requestModel);

        /// <summary>
        /// Deletes a channel's watermark image.
        /// </summary>
        RestResponse Unset(WatermarksUnsetRequest requestModel);
    }
}