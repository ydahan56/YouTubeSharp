using RestSharp;
using YouTubeSharp.PlaylistImages.Models.Request;
using YouTubeSharp.PlaylistImages.Models.Response;

namespace YouTubeSharp.PlaylistImages
{
    public interface IPlaylistImages
    {
        RestResponse<Models.Response.Root> list(PlaylistImagesListRequest requestModel);

        RestResponse<PlaylistImageItem> insert(PlaylistImagesInsertRequest queryParams, PlaylistImageItem bodyResource);

        RestResponse<PlaylistImageItem> update(PlaylistImagesUpdateRequest queryParams, PlaylistImageItem bodyResource);

        RestResponse delete(PlaylistImagesDeleteRequest requestModel);
    }
}