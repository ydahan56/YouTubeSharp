using RestSharp;
using YouTubeSharp.ChannelSections.Models.Request;
using YouTubeSharp.ChannelSections.Models.Response;

namespace YouTubeSharp.ChannelSections
{
    public class TChannelSections : IChannelSections
    {
        private readonly IRestClient _youtubeApi;

        public TChannelSections(IRestClient youtubeApi)
        {
            this._youtubeApi = youtubeApi;
        }

        public RestResponse<Models.Response.Root> list(ChannelSectionsListRequest requestModel)
        {
            var request = new RestRequest("/channelSections", Method.Get);

            request.AddQueryParameter("part", requestModel.Part);

            if (!string.IsNullOrWhiteSpace(requestModel.ChannelId))
                request.AddQueryParameter("channelId", requestModel.ChannelId);

            if (!string.IsNullOrWhiteSpace(requestModel.Id))
                request.AddQueryParameter("id", requestModel.Id);

            if (requestModel.Mine.HasValue)
                request.AddQueryParameter("mine", requestModel.Mine.Value.ToString().ToLower());

            if (!string.IsNullOrWhiteSpace(requestModel.Hl))
                request.AddQueryParameter("hl", requestModel.Hl);

            if (!string.IsNullOrWhiteSpace(requestModel.OnBehalfOfContentOwner))
                request.AddQueryParameter("onBehalfOfContentOwner", requestModel.OnBehalfOfContentOwner);

            return _youtubeApi.Execute<Models.Response.Root>(request);
        }

        public RestResponse<ChannelSectionItem> insert(ChannelSectionsInsertRequest queryParams, ChannelSectionItem bodyResource)
        {
            var request = new RestRequest("/channelSections", Method.Post);

            request.AddQueryParameter("part", queryParams.Part);

            if (!string.IsNullOrWhiteSpace(queryParams.OnBehalfOfContentOwner))
                request.AddQueryParameter("onBehalfOfContentOwner", queryParams.OnBehalfOfContentOwner);

            request.AddJsonBody(bodyResource);

            return _youtubeApi.Execute<ChannelSectionItem>(request);
        }

        public RestResponse<ChannelSectionItem> update(ChannelSectionsUpdateRequest queryParams, ChannelSectionItem bodyResource)
        {
            var request = new RestRequest("/channelSections", Method.Put);

            request.AddQueryParameter("part", queryParams.Part);

            if (!string.IsNullOrWhiteSpace(queryParams.OnBehalfOfContentOwner))
                request.AddQueryParameter("onBehalfOfContentOwner", queryParams.OnBehalfOfContentOwner);

            request.AddJsonBody(bodyResource);

            return _youtubeApi.Execute<ChannelSectionItem>(request);
        }

        public RestResponse delete(ChannelSectionsDeleteRequest requestModel)
        {
            var request = new RestRequest("/channelSections", Method.Delete);

            request.AddQueryParameter("id", requestModel.Id);

            if (!string.IsNullOrWhiteSpace(requestModel.OnBehalfOfContentOwner))
                request.AddQueryParameter("onBehalfOfContentOwner", requestModel.OnBehalfOfContentOwner);

            return _youtubeApi.Execute(request);
        }
    }
}