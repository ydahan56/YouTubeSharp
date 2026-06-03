using RestSharp;
using YouTubeSharp.VideoAbuseReportReasons.Models.Request;

namespace YouTubeSharp.VideoAbuseReportReasons
{
    public class TVideoAbuseReportReasons : IVideoAbuseReportReasons
    {
        private readonly IRestClient _youtubeApi;

        public TVideoAbuseReportReasons(IRestClient youtubeApi)
        {
            this._youtubeApi = youtubeApi;
        }

        public RestResponse<Models.Response.Root> list(VideoAbuseReportReasonsListRequest requestModel)
        {
            var request = new RestRequest("/videoAbuseReportReasons", Method.Get);

            request.AddQueryParameter("part", requestModel.Part);

            if (!string.IsNullOrWhiteSpace(requestModel.Hl))
                request.AddQueryParameter("hl", requestModel.Hl);

            return _youtubeApi.Execute<Models.Response.Root>(request);
        }
    }
}