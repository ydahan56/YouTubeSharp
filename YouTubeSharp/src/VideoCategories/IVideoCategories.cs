using RestSharp;
using YouTubeSharp.VideoCategories.Models.Request;
using YouTubeSharp.VideoCategories.Models.Response;

namespace YouTubeSharp.VideoCategories
{
    public interface IVideoCategories
    {
        /// <summary>
        /// Returns a list of categories that can be associated with YouTube videos.
        /// </summary>
        RestResponse<VideoCategoryListResponse> List(VideoCategoriesListRequest requestModel);
    }
}