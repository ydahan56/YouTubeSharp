using RestSharp;
using YouTubeSharp.Members.Models.Request;

namespace YouTubeSharp.Members
{
    public class Members : IMembers
    {
        private readonly IRestClient _youtubeApi;

        public Members(IRestClient youtubeApi)
        {
            this._youtubeApi = youtubeApi;
        }

        public RestResponse<Models.Response.Root> list(MembersListRequest requestModel)
        {
            var request = new RestRequest("/members", Method.Get);

            request.AddQueryParameter("part", requestModel.Part);

            if (!string.IsNullOrWhiteSpace(requestModel.HasAccessToLevel))
                request.AddQueryParameter("hasAccessToLevel", requestModel.HasAccessToLevel);

            if (requestModel.MaxResults.HasValue)
                request.AddQueryParameter("maxResults", requestModel.MaxResults.Value.ToString());

            if (!string.IsNullOrWhiteSpace(requestModel.Mode))
                request.AddQueryParameter("mode", requestModel.Mode);

            if (!string.IsNullOrWhiteSpace(requestModel.PageToken))
                request.AddQueryParameter("pageToken", requestModel.PageToken);

            return _youtubeApi.Execute<Models.Response.Root>(request);
        }
    }
}