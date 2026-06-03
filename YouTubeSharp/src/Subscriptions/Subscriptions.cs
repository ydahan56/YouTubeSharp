using RestSharp;
using YouTubeSharp.Subscriptions.Models.Request;
using YouTubeSharp.Subscriptions.Models.Response;

namespace YouTubeSharp.Subscriptions
{
    public class TSubscriptions : ISubscriptions
    {
        private readonly IRestClient _youtubeApi;

        public TSubscriptions(IRestClient youtubeApi)
        {
            this._youtubeApi = youtubeApi;
        }

        public RestResponse<Models.Response.Root> list(SubscriptionsListRequest requestModel)
        {
            var request = new RestRequest("/subscriptions", Method.Get);

            request.AddQueryParameter("part", requestModel.Part);

            // Conditional filters
            if (!string.IsNullOrWhiteSpace(requestModel.ChannelId))
                request.AddQueryParameter("channelId", requestModel.ChannelId);

            if (!string.IsNullOrWhiteSpace(requestModel.Id))
                request.AddQueryParameter("id", requestModel.Id);

            if (requestModel.Mine.HasValue)
                request.AddQueryParameter("mine", requestModel.Mine.Value.ToString().ToLower());

            if (requestModel.MySubscribers.HasValue)
                request.AddQueryParameter("mySubscribers", requestModel.MySubscribers.Value.ToString().ToLower());

            // Structural parameters
            if (!string.IsNullOrWhiteSpace(requestModel.ForChannelId))
                request.AddQueryParameter("forChannelId", requestModel.ForChannelId);

            if (requestModel.MaxResults.HasValue)
                request.AddQueryParameter("maxResults", requestModel.MaxResults.Value.ToString());

            if (!string.IsNullOrWhiteSpace(requestModel.Order))
                request.AddQueryParameter("order", requestModel.Order);

            if (!string.IsNullOrWhiteSpace(requestModel.PageToken))
                request.AddQueryParameter("pageToken", requestModel.PageToken);

            return _youtubeApi.Execute<Models.Response.Root>(request);
        }

        public RestResponse<SubscriptionItem> insert(SubscriptionsInsertRequest queryParams, SubscriptionItem bodyResource)
        {
            var request = new RestRequest("/subscriptions", Method.Post);

            request.AddQueryParameter("part", queryParams.Part);
            request.AddJsonBody(bodyResource);

            return _youtubeApi.Execute<SubscriptionItem>(request);
        }

        public RestResponse delete(SubscriptionsDeleteRequest requestModel)
        {
            var request = new RestRequest("/subscriptions", Method.Delete);

            request.AddQueryParameter("id", requestModel.Id);

            return _youtubeApi.Execute(request);
        }
    }
}