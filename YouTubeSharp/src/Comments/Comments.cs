using RestSharp;
using YouTubeSharp.Comments.Models.Request;
using YouTubeSharp.Comments.Models.Response;

namespace YouTubeSharp.Comments
{
    public class Comments : IComments
    {
        private readonly IRestClient _youtubeApi;

        public Comments(IRestClient youtubeApi)
        {
            this._youtubeApi = youtubeApi;
        }

        public RestResponse<Models.Response.Root> list(CommentsListRequest requestModel)
        {
            var request = new RestRequest("/comments", Method.Get);

            request.AddQueryParameter("part", requestModel.Part);

            if (!string.IsNullOrWhiteSpace(requestModel.Id))
                request.AddQueryParameter("id", requestModel.Id);

            if (!string.IsNullOrWhiteSpace(requestModel.ParentId))
                request.AddQueryParameter("parentId", requestModel.ParentId);

            if (requestModel.MaxResults.HasValue)
                request.AddQueryParameter("maxResults", requestModel.MaxResults.Value.ToString());

            if (!string.IsNullOrWhiteSpace(requestModel.PageToken))
                request.AddQueryParameter("pageToken", requestModel.PageToken);

            if (!string.IsNullOrWhiteSpace(requestModel.TextFormat))
                request.AddQueryParameter("textFormat", requestModel.TextFormat);

            return _youtubeApi.Execute<Models.Response.Root>(request);
        }

        public RestResponse<CommentItem> insert(CommentsInsertRequest queryParams, CommentItem bodyResource)
        {
            var request = new RestRequest("/comments", Method.Post);

            request.AddQueryParameter("part", queryParams.Part);
            request.AddJsonBody(bodyResource);

            return _youtubeApi.Execute<CommentItem>(request);
        }

        public RestResponse<CommentItem> update(CommentsUpdateRequest queryParams, CommentItem bodyResource)
        {
            var request = new RestRequest("/comments", Method.Put);

            request.AddQueryParameter("part", queryParams.Part);
            request.AddJsonBody(bodyResource);

            return _youtubeApi.Execute<CommentItem>(request);
        }

        public RestResponse delete(CommentsDeleteRequest requestModel)
        {
            var request = new RestRequest("/comments", Method.Delete);

            request.AddQueryParameter("id", requestModel.Id);

            return _youtubeApi.Execute(request);
        }

        public RestResponse setModerationStatus(CommentsSetModerationStatusRequest requestModel)
        {
            var request = new RestRequest("/comments/setModerationStatus", Method.Post);

            request.AddQueryParameter("id", requestModel.Id);
            request.AddQueryParameter("moderationStatus", requestModel.ModerationStatus);

            if (requestModel.BanAuthor.HasValue)
                request.AddQueryParameter("banAuthor", requestModel.BanAuthor.Value.ToString().ToLower());

            return _youtubeApi.Execute(request);
        }
    }
}