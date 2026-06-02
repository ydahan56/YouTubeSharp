using RestSharp;
using YouTubeSharp.ChannelSections.Models.Request;
using YouTubeSharp.ChannelSections.Models.Response;

namespace YouTubeSharp.ChannelSections
{
    public interface IChannelSections
    {
        RestResponse<Models.Response.Root> list(ChannelSectionsListRequest requestModel);
        
        RestResponse<ChannelSectionItem> insert(ChannelSectionsInsertRequest queryParams, ChannelSectionItem bodyResource);
        
        RestResponse<ChannelSectionItem> update(ChannelSectionsUpdateRequest queryParams, ChannelSectionItem bodyResource);
        
        RestResponse delete(ChannelSectionsDeleteRequest requestModel);
    }
}