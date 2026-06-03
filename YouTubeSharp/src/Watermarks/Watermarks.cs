using RestSharp;
using YouTubeSharp.Watermarks.Models.Request;

namespace YouTubeSharp.Watermarks
{
    public class TWatermarks : IWatermarks
    {
        private readonly IRestClient _youtubeApi;

        public TWatermarks(IRestClient youtubeApi)
        {
            this._youtubeApi = youtubeApi;
        }

        public RestResponse Set(WatermarksSetRequest requestModel)
        {
            // Google uses a distinct subdomain for binary/media uploads
            var request = new RestRequest("/watermarks/set", Method.Post);

            request.AddQueryParameter("channelId", requestModel.ChannelId);

            if (!string.IsNullOrWhiteSpace(requestModel.OnBehalfOfContentOwner))
                request.AddQueryParameter("onBehalfOfContentOwner", requestModel.OnBehalfOfContentOwner);

            // Attach the binary image payload
            if (requestModel.ImageBytes != null)
            {
                request.AddFile("media", requestModel.ImageBytes, requestModel.FileName, requestModel.ContentType);
            }

            // Attach metadata configuration if provided
            if (requestModel.Resource != null)
            {
                request.AddJsonBody(requestModel.Resource);
            }

            return _youtubeApi.Execute(request);
        }

        public RestResponse Unset(WatermarksUnsetRequest requestModel)
        {
            var request = new RestRequest("/watermarks/unset", Method.Post);

            request.AddQueryParameter("channelId", requestModel.ChannelId);

            if (!string.IsNullOrWhiteSpace(requestModel.OnBehalfOfContentOwner))
                request.AddQueryParameter("onBehalfOfContentOwner", requestModel.OnBehalfOfContentOwner);

            return _youtubeApi.Execute(request);
        }
    }
}