using RestSharp;
using YouTubeSharp.I18nLanguages.Models.Request;

namespace YouTubeSharp.I18nLanguages
{
    public class TI18nLanguages : II18nLanguages
    {
        private readonly IRestClient _youtubeApi;

        public TI18nLanguages(IRestClient youtubeApi)
        {
            this._youtubeApi = youtubeApi;
        }

        public RestResponse<Models.Response.Root> list(I18nLanguagesListRequest requestModel)
        {
            var request = new RestRequest("/i18nLanguages", Method.Get);

            request.AddQueryParameter("part", requestModel.Part);

            if (!string.IsNullOrWhiteSpace(requestModel.Hl))
                request.AddQueryParameter("hl", requestModel.Hl);

            return _youtubeApi.Execute<Models.Response.Root>(request);
        }
    }
}