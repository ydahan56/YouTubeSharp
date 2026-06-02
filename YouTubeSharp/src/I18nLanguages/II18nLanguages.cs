using RestSharp;
using YouTubeSharp.I18nLanguages.Models.Request;

namespace YouTubeSharp.I18nLanguages
{
    public interface II18nLanguages
    {
        /// <summary>
        /// Returns a list of application languages that the YouTube website supports.
        /// </summary>
        RestResponse<Models.Response.Root> list(I18nLanguagesListRequest requestModel);
    }
}