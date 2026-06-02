using RestSharp;
using YouTubeSharp.Playlists.Models.Request;
using YouTubeSharp.Playlists.Models.Response;

namespace YouTubeSharp.Playlists
{
    public interface IPlaylists
    {
        RestResponse<Models.Response.Root> list(PlaylistsListRequest requestModel);
        
        RestResponse<PlaylistItem> insert(PlaylistsInsertRequest queryParams, PlaylistItem bodyResource);
        
        RestResponse<PlaylistItem> update(PlaylistsUpdateRequest queryParams, PlaylistItem bodyResource);
        
        RestResponse delete(PlaylistsDeleteRequest requestModel);
    }
}