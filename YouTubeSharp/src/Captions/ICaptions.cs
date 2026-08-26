using RestSharp;
using YouTubeSharp.Captions.Models.Request;
using YouTubeSharp.Captions.Models.Response;

namespace YouTubeSharp.Captions
{
    public interface ICaptions
    {
        RestResponse<Models.Response.Root> list(CaptionsListRequest requestModel);

        RestResponse<CaptionItem> insert(CaptionsInsertRequest queryParams, CaptionResourceRequest bodyResource);

        RestResponse<CaptionItem> update(CaptionsUpdateRequest queryParams, CaptionResourceRequest bodyResource);

        RestResponse download(CaptionsDownloadRequest requestModel);

        RestResponse delete(CaptionsDeleteRequest requestModel);
    }
}