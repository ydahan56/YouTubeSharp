using RestSharp;
using YouTubeSharp.PlaylistImages.Models.Request;
using YouTubeSharp.PlaylistImages.Models.Response;

namespace YouTubeSharp.PlaylistImages
{
    public class TPlaylistImages : IPlaylistImages
    {
        private readonly IRestClient _youtubeApi;

        public TPlaylistImages(IRestClient youtubeApi)
        {
            this._youtubeApi = youtubeApi;
        }

        public RestResponse<Models.Response.Root> list(PlaylistImagesListRequest requestModel)
        {
            var request = new RestRequest("/playlistImages", Method.Get);

            request.AddQueryParameter("part", requestModel.Part);

            if (!string.IsNullOrWhiteSpace(requestModel.Id))
                request.AddQueryParameter("id", requestModel.Id);

            if (!string.IsNullOrWhiteSpace(requestModel.PlaylistId))
                request.AddQueryParameter("playlistId", requestModel.PlaylistId);

            if (requestModel.MaxResults.HasValue)
                request.AddQueryParameter("maxResults", requestModel.MaxResults.Value.ToString());

            if (!string.IsNullOrWhiteSpace(requestModel.PageToken))
                request.AddQueryParameter("pageToken", requestModel.PageToken);

            if (!string.IsNullOrWhiteSpace(requestModel.OnBehalfOfContentOwner))
                request.AddQueryParameter("onBehalfOfContentOwner", requestModel.OnBehalfOfContentOwner);

            if (!string.IsNullOrWhiteSpace(requestModel.OnBehalfOfContentOwnerChannel))
                request.AddQueryParameter("onBehalfOfContentOwnerChannel", requestModel.OnBehalfOfContentOwnerChannel);

            return _youtubeApi.Execute<Models.Response.Root>(request);
        }

        public RestResponse<PlaylistImageItem> insert(PlaylistImagesInsertRequest queryParams, PlaylistImageItem bodyResource)
        {
            var request = new RestRequest("/playlistImages", Method.Post);

            request.AddQueryParameter("part", queryParams.Part);
            
            if (!string.IsNullOrWhiteSpace(queryParams.OnBehalfOfContentOwner))
                request.AddQueryParameter("onBehalfOfContentOwner", queryParams.OnBehalfOfContentOwner);

            if (!string.IsNullOrWhiteSpace(queryParams.OnBehalfOfContentOwnerChannel))
                request.AddQueryParameter("onBehalfOfContentOwnerChannel", queryParams.OnBehalfOfContentOwnerChannel);

            request.AddJsonBody(bodyResource);

            return _youtubeApi.Execute<PlaylistImageItem>(request);
        }

        public RestResponse<PlaylistImageItem> update(PlaylistImagesUpdateRequest queryParams, PlaylistImageItem bodyResource)
        {
            var request = new RestRequest("/playlistImages", Method.Put);

            request.AddQueryParameter("part", queryParams.Part);

            if (!string.IsNullOrWhiteSpace(queryParams.OnBehalfOfContentOwner))
                request.AddQueryParameter("onBehalfOfContentOwner", queryParams.OnBehalfOfContentOwner);

            request.AddJsonBody(bodyResource);

            return _youtubeApi.Execute<PlaylistImageItem>(request);
        }

        public RestResponse delete(PlaylistImagesDeleteRequest requestModel)
        {
            var request = new RestRequest("/playlistImages", Method.Delete);

            request.AddQueryParameter("id", requestModel.Id);

            if (!string.IsNullOrWhiteSpace(requestModel.OnBehalfOfContentOwner))
                request.AddQueryParameter("onBehalfOfContentOwner", requestModel.OnBehalfOfContentOwner);

            return _youtubeApi.Execute(request);
        }
    }
}