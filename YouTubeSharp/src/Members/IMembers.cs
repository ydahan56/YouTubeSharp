using RestSharp;
using YouTubeSharp.Members.Models.Request;

namespace YouTubeSharp.Members
{
    public interface IMembers
    {
        /// <summary>
        /// Lists the channel members. Note: The authorized calling user must be the owner of the target channel.
        /// </summary>
        RestResponse<Models.Response.Root> list(MembersListRequest requestModel);
    }
}