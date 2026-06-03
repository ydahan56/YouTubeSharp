using RestSharp;
using YouTubeSharp.VideoCategories.Models.Request;
using YouTubeSharp.VideoCategories.Models.Response;

namespace YouTubeSharp.VideoCategories
{
    public class TVideoCategories : IVideoCategories
    {
        private readonly IRestClient _youtubeApi;

        public TVideoCategories(IRestClient youtubeApi)
        {
            this._youtubeApi = youtubeApi;
        }

        public RestResponse<VideoCategoryListResponse> List(VideoCategoriesListRequest requestModel)
        {
            var request = new RestRequest("/videoCategories", Method.Get);

            request.AddQueryParameter("part", requestModel.Part);

            if (!string.IsNullOrWhiteSpace(requestModel.Id))
                request.AddQueryParameter("id", requestModel.Id);

            if (!string.IsNullOrWhiteSpace(requestModel.RegionCode))
                request.AddQueryParameter("regionCode", requestModel.RegionCode);

            if (!string.IsNullOrWhiteSpace(requestModel.Hl))
                request.AddQueryParameter("hl", requestModel.Hl);

            return _youtubeApi.Execute<VideoCategoryListResponse>(request);
        }
    }
}