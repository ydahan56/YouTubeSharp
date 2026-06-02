using RestSharp;
using YouTubeSharp.MembershipsLevels.Models.Request;

namespace YouTubeSharp.MembershipsLevels
{
    public interface IMembershipsLevels
    {
        /// <summary>
        /// Lists the membership levels defined for the authorized user's channel.
        /// </summary>
        RestResponse<Models.Response.Root> list(MembershipsLevelsListRequest requestModel);
    }
}