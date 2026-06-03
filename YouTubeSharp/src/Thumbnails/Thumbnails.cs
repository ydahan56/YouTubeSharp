using RestSharp;
using YouTubeSharp.Thumbnails.Models.Request;

namespace YouTubeSharp.Thumbnails
{
    public class TThumbnails : IThumbnails
    {
        private readonly IRestClient _youtubeApi;

        public TThumbnails(IRestClient youtubeApi)
        {
            this._youtubeApi = youtubeApi;
        }

        public RestResponse<Models.Response.Root> set(ThumbnailsSetRequest queryParams, byte[] fileData, string fileName, string contentType = "image/jpeg")
        {
            // Note: Uploads may need to hit the "/upload/youtube/v3/thumbnails/set" endpoint routing depending on client configuration
            var request = new RestRequest("/thumbnails/set", Method.Post);

            request.AddQueryParameter("videoId", queryParams.VideoId);

            if (!string.IsNullOrWhiteSpace(queryParams.OnBehalfOfContentOwner))
                request.AddQueryParameter("onBehalfOfContentOwner", queryParams.OnBehalfOfContentOwner);

            // Attach the raw image binary data as a multipart form file
            request.AddFile("media", fileData, fileName, contentType);

            return _youtubeApi.Execute<Models.Response.Root>(request);
        }
    }
}