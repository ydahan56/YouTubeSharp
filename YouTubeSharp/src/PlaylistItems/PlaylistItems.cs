using RestSharp;
using YouTubeSharp.PlaylistItems.Models.Request;

namespace YouTubeSharp.PlaylistItems
{
    public class PlaylistItems : IPlaylistItems
    {
        private readonly IRestClient _youtubeApi;

        public PlaylistItems(IRestClient youtubeApi)
        {
            this._youtubeApi = youtubeApi;
        }

        /// <summary>
        /// Returns a collection of playlist items that match the API request criteria. 
        /// </summary>
        public RestResponse<Models.Response.Root> list(
            string part, 
            string? id = null, 
            string? playlistId = null, 
            int? maxResults = null, 
            string? pageToken = null, 
            string? videoId = null, 
            string? onBehalfOfContentOwner = null)
        {
            var request = new RestRequest("/playlistItems", Method.Get);
            
            // Required Parameter
            request.AddQueryParameter("part", part);

            // Filters (Exactly one of id or playlistId should be provided, though videoId is also supported as a filter)
            if (!string.IsNullOrWhiteSpace(id))
                request.AddQueryParameter("id", id);
                
            if (!string.IsNullOrWhiteSpace(playlistId))
                request.AddQueryParameter("playlistId", playlistId);
                
            if (!string.IsNullOrWhiteSpace(videoId))
                request.AddQueryParameter("videoId", videoId);

            // Optional Parameters
            if (maxResults.HasValue)
                request.AddQueryParameter("maxResults", maxResults.Value.ToString());
                
            if (!string.IsNullOrWhiteSpace(pageToken))
                request.AddQueryParameter("pageToken", pageToken);
                
            if (!string.IsNullOrWhiteSpace(onBehalfOfContentOwner))
                request.AddQueryParameter("onBehalfOfContentOwner", onBehalfOfContentOwner);

            return _youtubeApi.Execute<Models.Response.Root>(request);
        }

        /// <summary>
        /// Adds a new resource (usually a video) to a YouTube playlist.
        /// </summary>
        public RestResponse<Models.Response.Root> insert(
            string part, 
            Models.Request.PlaylistItem item, 
            string? onBehalfOfContentOwner = null)
        {
            var request = new RestRequest("/playlistItems", Method.Post);
            
            // Required Parameter
            request.AddQueryParameter("part", part);

            // Optional Parameter
            if (!string.IsNullOrWhiteSpace(onBehalfOfContentOwner))
                request.AddQueryParameter("onBehalfOfContentOwner", onBehalfOfContentOwner);

            // Request Body
            request.AddJsonBody(item);

            return this._youtubeApi.Execute<Models.Response.Root>(request);
        }

        /// <summary>
        /// Updates or creates a playlist item within a YouTube playlist.
        /// </summary>
        public RestResponse<Models.Response.Root> update(
            string part, 
            Models.Request.PlaylistItem item, 
            string? onBehalfOfContentOwner = null)
        {
            // Note: Updated to use Method.Put per REST API standards for updates
            var request = new RestRequest("/playlistItems", Method.Put);
            
            // Required Parameter
            request.AddQueryParameter("part", part);

            // Optional Parameter
            if (!string.IsNullOrWhiteSpace(onBehalfOfContentOwner))
                request.AddQueryParameter("onBehalfOfContentOwner", onBehalfOfContentOwner);

            // Request Body
            request.AddJsonBody(item);

            return this._youtubeApi.Execute<Models.Response.Root>(request);
        }

        /// <summary>
        /// Deletes a specified item from a YouTube playlist.
        /// </summary>
        public RestResponse delete(string id, string? onBehalfOfContentOwner = null)
        {
            var request = new RestRequest("/playlistItems", Method.Delete);
            
            // Required Parameter
            request.AddQueryParameter("id", id);

            // Optional Parameter
            if (!string.IsNullOrWhiteSpace(onBehalfOfContentOwner))
                request.AddQueryParameter("onBehalfOfContentOwner", onBehalfOfContentOwner);

            return this._youtubeApi.Execute(request);
        }
    }
}