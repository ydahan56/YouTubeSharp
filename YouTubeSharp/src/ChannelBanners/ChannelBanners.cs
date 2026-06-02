using RestSharp;
using YouTubeSharp.ChannelBanners.Models.Request;
using YouTubeSharp.ChannelBanners.Models.Response;

namespace YouTubeSharp.ChannelBanners
{
    public class ChannelBanners : IChannelBanners
    {
        private readonly IRestClient _youtubeApi;

        public ChannelBanners(IRestClient youtubeApi)
        {
            this._youtubeApi = youtubeApi;
        }

        public RestResponse<ChannelBannerResource> insert(
            ChannelBannersInsertRequest queryParams, 
            byte[] fileBytes, 
            string fileName, 
            string mimeType)
        {
            // Note: YouTube Media upload structures are typically directed toward 
            // the specialized media upload endpoint context: "https://www.googleapis.com/upload/youtube/v3/channelBanners/insert"
            var request = new RestRequest("/channelBanners/insert", Method.Post);

            if (!string.IsNullOrWhiteSpace(queryParams.ChannelId))
                request.AddQueryParameter("channelId", queryParams.ChannelId);

            if (!string.IsNullOrWhiteSpace(queryParams.OnBehalfOfContentOwner))
                request.AddQueryParameter("onBehalfOfContentOwner", queryParams.OnBehalfOfContentOwner);

            // Attach image files securely as a multipart form file context element
            request.AddFile("media", fileBytes, fileName, mimeType);

            return _youtubeApi.Execute<ChannelBannerResource>(request);
        }
    }
}