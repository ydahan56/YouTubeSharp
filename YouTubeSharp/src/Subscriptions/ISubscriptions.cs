using RestSharp;
using YouTubeSharp.Subscriptions.Models.Request;
using YouTubeSharp.Subscriptions.Models.Response;

namespace YouTubeSharp.Subscriptions
{
    public interface ISubscriptions
    {
        RestResponse<Models.Response.Root> list(SubscriptionsListRequest requestModel);
        
        RestResponse<SubscriptionItem> insert(SubscriptionsInsertRequest queryParams, SubscriptionItem bodyResource);
        
        RestResponse delete(SubscriptionsDeleteRequest requestModel);
    }
}