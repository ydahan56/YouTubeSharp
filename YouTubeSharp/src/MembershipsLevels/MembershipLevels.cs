using RestSharp;
using YouTubeSharp.MembershipsLevels.Models.Request;

namespace YouTubeSharp.MembershipsLevels
{
    public class MembershipsLevels : IMembershipsLevels
    {
        private readonly IRestClient _youtubeApi;

        public MembershipsLevels(IRestClient youtubeApi)
        {
            this._youtubeApi = youtubeApi;
        }

        public RestResponse<Models.Response.Root> list(MembershipsLevelsListRequest requestModel)
        {
            var request = new RestRequest("/membershipsLevels", Method.Get);

            request.AddQueryParameter("part", requestModel.Part);

            if (!string.IsNullOrWhiteSpace(requestModel.Hl))
                request.AddQueryParameter("hl", requestModel.Hl);

            return _youtubeApi.Execute<Models.Response.Root>(request);
        }
    }
}