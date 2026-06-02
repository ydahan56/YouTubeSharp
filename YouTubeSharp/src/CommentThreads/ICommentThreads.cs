using RestSharp;
using YouTubeSharp.CommentThreads.Models.Request;
using YouTubeSharp.CommentThreads.Models.Response;

namespace YouTubeSharp.CommentThreads
{
    public interface ICommentThreads
    {
        RestResponse<Models.Response.Root> list(CommentThreadsListRequest requestModel);
        
        RestResponse<CommentThreadItem> insert(CommentThreadsInsertRequest queryParams, CommentThreadItem bodyResource);
    }
}