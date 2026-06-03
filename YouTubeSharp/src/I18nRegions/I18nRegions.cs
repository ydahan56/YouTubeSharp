using RestSharp;
using YouTubeSharp.I18nRegions.Models.Request;

namespace YouTubeSharp.I18nRegions
{
    public class TI18nRegions : II18nRegions
    {
        private readonly IRestClient _youtubeApi;

        public TI18nRegions(IRestClient youtubeApi)
        {
            this._youtubeApi = youtubeApi;
        }

        public RestResponse<Models.Response.Root> list(I18nRegionsListRequest requestModel)
        {
            var request = new RestRequest("/i18nRegions", Method.Get);

            request.AddQueryParameter("part", requestModel.Part);

            if (!string.IsNullOrWhiteSpace(requestModel.Hl))
                request.AddQueryParameter("hl", requestModel.Hl);

            return _youtubeApi.Execute<Models.Response.Root>(request);
        }
    }
}