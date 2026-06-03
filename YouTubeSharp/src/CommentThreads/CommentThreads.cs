using RestSharp;
using YouTubeSharp.CommentThreads.Models.Request;
using YouTubeSharp.CommentThreads.Models.Response;

namespace YouTubeSharp.CommentThreads
{
    public class TCommentThreads : ICommentThreads
    {
        private readonly IRestClient _youtubeApi;

        public TCommentThreads(IRestClient youtubeApi)
        {
            this._youtubeApi = youtubeApi;
        }

        public RestResponse<Models.Response.Root> list(CommentThreadsListRequest requestModel)
        {
            var request = new RestRequest("/commentThreads", Method.Get);

            request.AddQueryParameter("part", requestModel.Part);

            // Mutually exclusive filter conditions
            if (!string.IsNullOrWhiteSpace(requestModel.AllThreadsRelatedToChannelId))
                request.AddQueryParameter("allThreadsRelatedToChannelId", requestModel.AllThreadsRelatedToChannelId);

            if (!string.IsNullOrWhiteSpace(requestModel.ChannelId))
                request.AddQueryParameter("channelId", requestModel.ChannelId);

            if (!string.IsNullOrWhiteSpace(requestModel.Id))
                request.AddQueryParameter("id", requestModel.Id);

            if (!string.IsNullOrWhiteSpace(requestModel.VideoId))
                request.AddQueryParameter("videoId", requestModel.VideoId);

            // Optional structural metadata options
            if (requestModel.MaxResults.HasValue)
                request.AddQueryParameter("maxResults", requestModel.MaxResults.Value.ToString());

            if (!string.IsNullOrWhiteSpace(requestModel.ModerationStatus))
                request.AddQueryParameter("moderationStatus", requestModel.ModerationStatus);

            if (!string.IsNullOrWhiteSpace(requestModel.Order))
                request.AddQueryParameter("order", requestModel.Order);

            if (!string.IsNullOrWhiteSpace(requestModel.PageToken))
                request.AddQueryParameter("pageToken", requestModel.PageToken);

            if (!string.IsNullOrWhiteSpace(requestModel.SearchTerms))
                request.AddQueryParameter("searchTerms", requestModel.SearchTerms);

            if (!string.IsNullOrWhiteSpace(requestModel.TextFormat))
                request.AddQueryParameter("textFormat", requestModel.TextFormat);

            return _youtubeApi.Execute<Models.Response.Root>(request);
        }

        public RestResponse<CommentThreadItem> insert(CommentThreadsInsertRequest queryParams, CommentThreadItem bodyResource)
        {
            var request = new RestRequest("/commentThreads", Method.Post);

            request.AddQueryParameter("part", queryParams.Part);
            request.AddJsonBody(bodyResource);

            return _youtubeApi.Execute<CommentThreadItem>(request);
        }
    }
}