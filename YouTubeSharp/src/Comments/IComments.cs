using RestSharp;
using YouTubeSharp.Comments.Models.Request;
using YouTubeSharp.Comments.Models.Response;

namespace YouTubeSharp.Comments
{
    public interface IComments
    {
        RestResponse<Models.Response.Root> list(CommentsListRequest requestModel);
        
        RestResponse<CommentItem> insert(CommentsInsertRequest queryParams, CommentItem bodyResource);
        
        RestResponse<CommentItem> update(CommentsUpdateRequest queryParams, CommentItem bodyResource);
        
        RestResponse delete(CommentsDeleteRequest requestModel);
        
        RestResponse setModerationStatus(CommentsSetModerationStatusRequest requestModel);
    }
}