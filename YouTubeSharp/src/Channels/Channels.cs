using RestSharp;
using YouTubeSharp.Channels.Models.Request;
using YouTubeSharp.Channels.Models.Response;

namespace YouTubeSharp.Channels
{
    public class TChannels : IChannels
    {
        private readonly IRestClient _youtubeApi;

        public TChannels(IRestClient youtubeApi)
        {
            this._youtubeApi = youtubeApi;
        }

        public RestResponse<Models.Response.Root> list(ChannelsListRequest requestModel)
        {
            var request = new RestRequest("/channels", Method.Get);

            request.AddQueryParameter("part", requestModel.Part);

            // Conditional parameter mappings
            if (!string.IsNullOrWhiteSpace(requestModel.Id))
                request.AddQueryParameter("id", requestModel.Id);

            if (!string.IsNullOrWhiteSpace(requestModel.ForUsername))
                request.AddQueryParameter("forUsername", requestModel.ForUsername);

            if (requestModel.ManagedByMe.HasValue)
                request.AddQueryParameter("managedByMe", requestModel.ManagedByMe.Value.ToString().ToLower());

            if (requestModel.Mine.HasValue)
                request.AddQueryParameter("mine", requestModel.Mine.Value.ToString().ToLower());

            if (requestModel.MaxResults.HasValue)
                request.AddQueryParameter("maxResults", requestModel.MaxResults.Value.ToString());

            if (!string.IsNullOrWhiteSpace(requestModel.PageToken))
                request.AddQueryParameter("pageToken", requestModel.PageToken);

            if (!string.IsNullOrWhiteSpace(requestModel.Hl))
                request.AddQueryParameter("hl", requestModel.Hl);

            if (!string.IsNullOrWhiteSpace(requestModel.OnBehalfOfContentOwner))
                request.AddQueryParameter("onBehalfOfContentOwner", requestModel.OnBehalfOfContentOwner);

            return _youtubeApi.Execute<Models.Response.Root>(request);
        }

        public RestResponse<ChannelItem> update(ChannelsUpdateRequest queryParams, ChannelItem bodyResource)
        {
            var request = new RestRequest("/channels", Method.Put);

            request.AddQueryParameter("part", queryParams.Part);

            if (!string.IsNullOrWhiteSpace(queryParams.OnBehalfOfContentOwner))
                request.AddQueryParameter("onBehalfOfContentOwner", queryParams.OnBehalfOfContentOwner);

            // Attach the modified channel resource body data
            request.AddJsonBody(bodyResource);

            return _youtubeApi.Execute<ChannelItem>(request);
        }
    }
}