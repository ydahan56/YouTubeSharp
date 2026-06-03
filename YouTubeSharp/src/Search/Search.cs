using RestSharp;
using YouTubeSharp.Search;

namespace YouTubeSharp.Search;

public class TSearch : ISearch
{
    private readonly IRestClient _youtubeApi;

    public TSearch(IRestClient youtubeApi)
    {
        this._youtubeApi = youtubeApi;
    }

    public RestResponse<Models.Response.Root> list(
        string? part = null,
        string? id = null,
        string? playlistId = null,
        int? maxResults = null,
        string? pageToken = null,
        string? videoId = null,
        string? onBehalfOfContentOwner = null)
    {
        var request = new RestRequest("/playlistItems", Method.Get);

        if (!string.IsNullOrWhiteSpace(part))
            request.AddQueryParameter("part", part);

        if (!string.IsNullOrWhiteSpace(id))
            request.AddQueryParameter("id", id);

        if (!string.IsNullOrWhiteSpace(playlistId))
            request.AddQueryParameter("playlistId", playlistId);

        if (!string.IsNullOrWhiteSpace(videoId))
            request.AddQueryParameter("videoId", videoId);

        if (maxResults.HasValue)
            request.AddQueryParameter("maxResults", maxResults.Value.ToString());

        if (!string.IsNullOrWhiteSpace(pageToken))
            request.AddQueryParameter("pageToken", pageToken);

        if (!string.IsNullOrWhiteSpace(onBehalfOfContentOwner))
            request.AddQueryParameter("onBehalfOfContentOwner", onBehalfOfContentOwner);

        return _youtubeApi.Execute<Models.Response.Root>(request);
    }

    public RestResponse<Models.Response.Root> insert(
        string? part = null,
        Models.Request.Root? item = null,
        string? onBehalfOfContentOwner = null)
    {
        var request = new RestRequest("/playlistItems", Method.Post);

        if (!string.IsNullOrWhiteSpace(part))
            request.AddQueryParameter("part", part);

        if (!string.IsNullOrWhiteSpace(onBehalfOfContentOwner))
            request.AddQueryParameter("onBehalfOfContentOwner", onBehalfOfContentOwner);

        if (item != null)
            request.AddJsonBody(item);

        return this._youtubeApi.Execute<Models.Response.Root>(request);
    }

    public RestResponse<Models.Response.Root> update(
        string? part = null,
        Models.Request.Root? item = null,
        string? onBehalfOfContentOwner = null)
    {
        var request = new RestRequest("/playlistItems", Method.Put);

        if (!string.IsNullOrWhiteSpace(part))
            request.AddQueryParameter("part", part);

        if (!string.IsNullOrWhiteSpace(onBehalfOfContentOwner))
            request.AddQueryParameter("onBehalfOfContentOwner", onBehalfOfContentOwner);

        if (item != null)
            request.AddJsonBody(item);

        return this._youtubeApi.Execute<Models.Response.Root>(request);
    }

    public RestResponse delete(
        string? id = null,
        string? onBehalfOfContentOwner = null)
    {
        var request = new RestRequest("/playlistItems", Method.Delete);

        if (!string.IsNullOrWhiteSpace(id))
            request.AddQueryParameter("id", id);

        if (!string.IsNullOrWhiteSpace(onBehalfOfContentOwner))
            request.AddQueryParameter("onBehalfOfContentOwner", onBehalfOfContentOwner);

        return this._youtubeApi.Execute(request);
    }
}
