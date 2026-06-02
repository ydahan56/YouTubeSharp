using RestSharp;

namespace YouTubeSharp.Activities
{
    public class Activities : IActivities
    {
        private readonly IRestClient _youtubeApi;

        public Activities(IRestClient youtubeApi)
        {
            this._youtubeApi = youtubeApi;
        }

        public RestResponse<Models.Response.Root> list(
            string? part = null, 
            string? channelId = null, 
            bool? mine = null, 
            int? maxResults = null, 
            string? pageToken = null, 
            string? publishedAfter = null, 
            string? publishedBefore = null, 
            string? regionCode = null)
        {
            var request = new RestRequest("/activities", Method.Get);
            
            if (!string.IsNullOrWhiteSpace(part))
                request.AddQueryParameter("part", part);

            if (!string.IsNullOrWhiteSpace(channelId))
                request.AddQueryParameter("channelId", channelId);
                
            if (mine.HasValue)
                request.AddQueryParameter("mine", mine.Value.ToString().ToLower());

            if (maxResults.HasValue)
                request.AddQueryParameter("maxResults", maxResults.Value.ToString());
                
            if (!string.IsNullOrWhiteSpace(pageToken))
                request.AddQueryParameter("pageToken", pageToken);
                
            if (!string.IsNullOrWhiteSpace(publishedAfter))
                request.AddQueryParameter("publishedAfter", publishedAfter);

            if (!string.IsNullOrWhiteSpace(publishedBefore))
                request.AddQueryParameter("publishedBefore", publishedBefore);

            if (!string.IsNullOrWhiteSpace(regionCode))
                request.AddQueryParameter("regionCode", regionCode);

            return _youtubeApi.Execute<Models.Response.Root>(request);
        }
    }
}