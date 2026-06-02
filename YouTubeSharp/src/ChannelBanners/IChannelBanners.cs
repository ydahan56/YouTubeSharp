using RestSharp;
using YouTubeSharp.ChannelBanners.Models.Request;
using YouTubeSharp.ChannelBanners.Models.Response;

namespace YouTubeSharp.ChannelBanners
{
    public interface IChannelBanners
    {
        /// <summary>
        /// Uploads a channel banner image to YouTube. 
        /// </summary>
        /// <param name="queryParams">The request query configurations.</param>
        /// <param name="fileBytes">The raw binary array data of the banner image.</param>
        /// <param name="fileName">The image file name (e.g., "banner.png").</param>
        /// <param name="mimeType">The image MIME content type (e.g., "image/png", "image/jpeg").</param>
        /// <returns>A RestResponse returning the ChannelBannerResource confirmation data.</returns>
        RestResponse<ChannelBannerResource> insert(
            ChannelBannersInsertRequest queryParams, 
            byte[] fileBytes, 
            string fileName, 
            string mimeType);
    }
}