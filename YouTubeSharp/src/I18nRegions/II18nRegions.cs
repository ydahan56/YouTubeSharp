using RestSharp;
using YouTubeSharp.I18nRegions.Models.Request;

namespace YouTubeSharp.I18nRegions
{
    public interface II18nRegions
    {
        /// <summary>
        /// Returns a list of content regions that the YouTube website supports.
        /// </summary>
        RestResponse<Models.Response.Root> list(I18nRegionsListRequest requestModel);
    }
}