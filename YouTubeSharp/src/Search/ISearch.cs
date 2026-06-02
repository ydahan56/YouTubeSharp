using RestSharp;

namespace YouTubeSharp.Search;

public interface ISearch
{
    RestResponse<Models.Response.Root> list(
        string? part = null,
        string? id = null,
        string? playlistId = null,
        int? maxResults = null,
        string? pageToken = null,
        string? videoId = null,
        string? onBehalfOfContentOwner = null);

    RestResponse<Models.Response.Root> insert(
        string? part = null,
        Models.Request.Root? item = null,
        string? onBehalfOfContentOwner = null);

    RestResponse<Models.Response.Root> update(
        string? part = null,
        Models.Request.Root? item = null,
        string? onBehalfOfContentOwner = null);

    RestResponse delete(
        string? id = null,
        string? onBehalfOfContentOwner = null);
}
