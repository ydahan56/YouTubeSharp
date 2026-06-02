using RestSharp;
using YouTubeSharp.Captions.Models.Request;
using YouTubeSharp.Captions.Models.Response;

namespace YouTubeSharp.Captions
{
    public class Captions : ICaptions
    {
        private readonly IRestClient _youtubeApi;

        public Captions(IRestClient youtubeApi)
        {
            this._youtubeApi = youtubeApi;
        }

        public RestResponse<Models.Response.Root> list(CaptionsListRequest requestModel)
        {
            var request = new RestRequest("/captions", Method.Get);

            request.AddQueryParameter("part", requestModel.Part);
            request.AddQueryParameter("videoId", requestModel.VideoId);

            if (!string.IsNullOrWhiteSpace(requestModel.Id))
                request.AddQueryParameter("id", requestModel.Id);

            if (!string.IsNullOrWhiteSpace(requestModel.OnBehalfOfContentOwner))
                request.AddQueryParameter("onBehalfOfContentOwner", requestModel.OnBehalfOfContentOwner);

            return _youtubeApi.Execute<Models.Response.Root>(request);
        }

        public RestResponse<CaptionItem> insert(CaptionsInsertRequest queryParams, CaptionResourceRequest bodyResource)
        {
            var request = new RestRequest("/captions", Method.Post);

            request.AddQueryParameter("part", queryParams.Part);

            if (!string.IsNullOrWhiteSpace(queryParams.OnBehalfOfContentOwner))
                request.AddQueryParameter("onBehalfOfContentOwner", queryParams.OnBehalfOfContentOwner);

            request.AddJsonBody(bodyResource);

            return _youtubeApi.Execute<CaptionItem>(request);
        }

        public RestResponse<CaptionItem> update(CaptionsUpdateRequest queryParams, CaptionResourceRequest bodyResource)
        {
            var request = new RestRequest("/captions", Method.Put);

            request.AddQueryParameter("part", queryParams.Part);

            if (!string.IsNullOrWhiteSpace(queryParams.OnBehalfOfContentOwner))
                request.AddQueryParameter("onBehalfOfContentOwner", queryParams.OnBehalfOfContentOwner);

            request.AddJsonBody(bodyResource);

            return _youtubeApi.Execute<CaptionItem>(request);
        }

        public RestResponse download(CaptionsDownloadRequest requestModel)
        {
            // The download mechanism targets /captions/id or parses id as a query constraint depending on setup
            var request = new RestRequest($"/captions/{requestModel.Id}", Method.Get);

            if (!string.IsNullOrWhiteSpace(requestModel.Tfmt))
                request.AddQueryParameter("tfmt", requestModel.Tfmt);

            if (!string.IsNullOrWhiteSpace(requestModel.Tlang))
                request.AddQueryParameter("tlang", requestModel.Tlang);

            if (!string.IsNullOrWhiteSpace(requestModel.OnBehalfOfContentOwner))
                request.AddQueryParameter("onBehalfOfContentOwner", requestModel.OnBehalfOfContentOwner);

            // Returns raw RestResponse context because download returns track file content (e.g., raw SRT/VTT text or binary bytes)
            return _youtubeApi.Execute(request);
        }

        public RestResponse delete(CaptionsDeleteRequest requestModel)
        {
            var request = new RestRequest("/captions", Method.Delete);

            request.AddQueryParameter("id", requestModel.Id);

            if (!string.IsNullOrWhiteSpace(requestModel.OnBehalfOfContentOwner))
                request.AddQueryParameter("onBehalfOfContentOwner", requestModel.OnBehalfOfContentOwner);

            return _youtubeApi.Execute(request);
        }
    }
}