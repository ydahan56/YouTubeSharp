using RestSharp;
using YouTubeSharp.Playlists.Models.Request;
using YouTubeSharp.Playlists.Models.Response;

namespace YouTubeSharp.Playlists
{
    public class Playlists : IPlaylists
    {
        private readonly IRestClient _youtubeApi;

        public Playlists(IRestClient youtubeApi)
        {
            this._youtubeApi = youtubeApi;
        }

        public RestResponse<Models.Response.Root> list(PlaylistsListRequest requestModel)
        {
            var request = new RestRequest("/playlists", Method.Get);

            request.AddQueryParameter("part", requestModel.Part);

            if (!string.IsNullOrWhiteSpace(requestModel.ChannelId))
                request.AddQueryParameter("channelId", requestModel.ChannelId);

            if (!string.IsNullOrWhiteSpace(requestModel.Id))
                request.AddQueryParameter("id", requestModel.Id);

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

            if (!string.IsNullOrWhiteSpace(requestModel.OnBehalfOfContentOwnerChannel))
                request.AddQueryParameter("onBehalfOfContentOwnerChannel", requestModel.OnBehalfOfContentOwnerChannel);

            return _youtubeApi.Execute<Models.Response.Root>(request);
        }

        public RestResponse<PlaylistItem> insert(PlaylistsInsertRequest queryParams, PlaylistItem bodyResource)
        {
            var request = new RestRequest("/playlists", Method.Post);

            request.AddQueryParameter("part", queryParams.Part);

            if (!string.IsNullOrWhiteSpace(queryParams.OnBehalfOfContentOwner))
                request.AddQueryParameter("onBehalfOfContentOwner", queryParams.OnBehalfOfContentOwner);

            if (!string.IsNullOrWhiteSpace(queryParams.OnBehalfOfContentOwnerChannel))
                request.AddQueryParameter("onBehalfOfContentOwnerChannel", queryParams.OnBehalfOfContentOwnerChannel);

            request.AddJsonBody(bodyResource);

            return _youtubeApi.Execute<PlaylistItem>(request);
        }

        public RestResponse<PlaylistItem> update(PlaylistsUpdateRequest queryParams, PlaylistItem bodyResource)
        {
            var request = new RestRequest("/playlists", Method.Put);

            request.AddQueryParameter("part", queryParams.Part);

            if (!string.IsNullOrWhiteSpace(queryParams.OnBehalfOfContentOwner))
                request.AddQueryParameter("onBehalfOfContentOwner", queryParams.OnBehalfOfContentOwner);

            request.AddJsonBody(bodyResource);

            return _youtubeApi.Execute<PlaylistItem>(request);
        }

        public RestResponse delete(PlaylistsDeleteRequest requestModel)
        {
            var request = new RestRequest("/playlists", Method.Delete);

            request.AddQueryParameter("id", requestModel.Id);

            if (!string.IsNullOrWhiteSpace(requestModel.OnBehalfOfContentOwner))
                request.AddQueryParameter("onBehalfOfContentOwner", requestModel.OnBehalfOfContentOwner);

            return _youtubeApi.Execute(request);
        }
    }
}