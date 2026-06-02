using RestSharp;
using YouTubeSharp.Videos.Models.Request;
using YouTubeSharp.Videos.Models.Response;

namespace YouTubeSharp.Videos
{
    public class Videos : IVideos
    {
        private readonly IRestClient _youtubeApi;

        public Videos(IRestClient youtubeApi)
        {
            this._youtubeApi = youtubeApi;
        }

        public RestResponse<VideoListResponse> List(VideosListRequest requestModel)
        {
            var request = new RestRequest("/videos", Method.Get);

            request.AddQueryParameter("part", requestModel.Part);

            if (!string.IsNullOrWhiteSpace(requestModel.Id))
                request.AddQueryParameter("id", requestModel.Id);

            if (!string.IsNullOrWhiteSpace(requestModel.Chart))
                request.AddQueryParameter("chart", requestModel.Chart);

            if (requestModel.MaxResults.HasValue)
                request.AddQueryParameter("maxResults", requestModel.MaxResults.Value.ToString());

            if (!string.IsNullOrWhiteSpace(requestModel.PageToken))
                request.AddQueryParameter("pageToken", requestModel.PageToken);

            if (!string.IsNullOrWhiteSpace(requestModel.RegionCode))
                request.AddQueryParameter("regionCode", requestModel.RegionCode);

            if (!string.IsNullOrWhiteSpace(requestModel.VideoCategoryId))
                request.AddQueryParameter("videoCategoryId", requestModel.VideoCategoryId);

            if (!string.IsNullOrWhiteSpace(requestModel.MyRating))
                request.AddQueryParameter("myRating", requestModel.MyRating);

            return _youtubeApi.Execute<VideoListResponse>(request);
        }

        public RestResponse<Video> Insert(VideosInsertRequest requestModel)
        {
            // Video file uploads go to the specialized media upload endpoint
            var request = new RestRequest("/videos", Method.Post);

            request.AddQueryParameter("part", requestModel.Part);

            if (requestModel.NotifySubscribers.HasValue)
                request.AddQueryParameter("notifySubscribers", requestModel.NotifySubscribers.Value.ToString().ToLower());

            // Add the video metadata resource configuration
            if (requestModel.Resource != null)
                request.AddJsonBody(requestModel.Resource);

            // Add the actual video binary file
            if (requestModel.VideoBytes != null)
                request.AddFile("media", requestModel.VideoBytes, requestModel.FileName ?? "video.mp4", requestModel.ContentType ?? "video/mp4");

            return _youtubeApi.Execute<Video>(request);
        }

        public RestResponse<Video> Update(VideosUpdateRequest requestModel)
        {
            var request = new RestRequest("/videos", Method.Put);

            request.AddQueryParameter("part", requestModel.Part);

            if (requestModel.Resource != null)
                request.AddJsonBody(requestModel.Resource);

            return _youtubeApi.Execute<Video>(request);
        }

        public RestResponse Delete(VideosDeleteRequest requestModel)
        {
            var request = new RestRequest("/videos", Method.Delete);

            request.AddQueryParameter("id", requestModel.Id);

            return _youtubeApi.Execute(request);
        }
    }
}