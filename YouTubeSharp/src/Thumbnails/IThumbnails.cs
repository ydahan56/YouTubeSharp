using RestSharp;
using YouTubeSharp.Thumbnails.Models.Request;

namespace YouTubeSharp.Thumbnails
{
    public interface IThumbnails
    {
        /// <summary>
        /// Uploads a custom video thumbnail image and sets it for a video.
        /// </summary>
        RestResponse<Models.Response.Root> set(ThumbnailsSetRequest queryParams, byte[] fileData, string fileName, string contentType = "image/jpeg");
    }
}