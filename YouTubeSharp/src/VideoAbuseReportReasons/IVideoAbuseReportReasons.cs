using RestSharp;
using YouTubeSharp.VideoAbuseReportReasons.Models.Request;

namespace YouTubeSharp.VideoAbuseReportReasons
{
    public interface IVideoAbuseReportReasons
    {
        /// <summary>
        /// Returns a list of reasons that can be used to report abusive videos.
        /// </summary>
        RestResponse<Models.Response.Root> list(VideoAbuseReportReasonsListRequest requestModel);
    }
}