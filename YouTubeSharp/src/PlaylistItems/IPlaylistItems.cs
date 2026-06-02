using RestSharp;

namespace YouTubeSharp.PlaylistItems
{
    public interface IPlaylistItems
    {
        RestResponse<Models.Response.Root> list(string part, string? id = null, string? playlistId = null, int? maxResults = null, string? pageToken = null, string? videoId = null, string? onBehalfOfContentOwner = null);
        RestResponse<Models.Response.Root> insert(string part, Models.Request.PlaylistItem item, string? onBehalfOfContentOwner = null);
        RestResponse<Models.Response.Root> update(string part, Models.Request.PlaylistItem item, string? onBehalfOfContentOwner = null);
        RestResponse delete(string id, string? onBehalfOfContentOwner = null);
    }
}