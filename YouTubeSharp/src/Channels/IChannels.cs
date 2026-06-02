using RestSharp;
using YouTubeSharp.Channels.Models.Request;
using YouTubeSharp.Channels.Models.Response;

namespace YouTubeSharp.Channels
{
    public interface IChannels
    {
        /// <summary>
        /// Returns a collection of zero or more channel resources that match the request criteria.
        /// </summary>
        RestResponse<Models.Response.Root> list(ChannelsListRequest requestModel);

        /// <summary>
        /// Updates a channel's metadata (such as branding settings or localizations).
        /// </summary>
        RestResponse<ChannelItem> update(ChannelsUpdateRequest queryParams, ChannelItem bodyResource);
    }
}