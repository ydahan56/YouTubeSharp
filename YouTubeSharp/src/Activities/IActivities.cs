using RestSharp;

namespace YouTubeSharp.Activities
{
    public interface IActivities
    {
        /// <summary>
        /// Retrieves a list of channel activity events matching the request criteria.
        /// </summary>
        /// <param name="part">The part parameter specifies a comma-separated list of one or more activity resource properties that the API response will include.</param>
        /// <param name="channelId">The channelId parameter specifies a unique YouTube channel ID. The API will then return that channel's activities.</param>
        /// <param name="mine">Set this parameter's value to true to retrieve a feed of the authenticated user's activities.</param>
        /// <param name="maxResults">The maxResults parameter specifies the maximum number of items that should be returned in the result set.</param>
        /// <param name="pageToken">The pageToken parameter identifies a specific page in the result set that should be returned.</param>
        /// <param name="publishedAfter">The publishedAfter parameter specifies the earliest date and time that an activity can have been created.</param>
        /// <param name="publishedBefore">The publishedBefore parameter specifies the latest date and time that an activity can have been created.</param>
        /// <param name="regionCode">The regionCode parameter instructs the API to return results for the specified country.</param>
        /// <returns>A RestResponse containing the root response model.</returns>
        RestResponse<Models.Response.Root> list(
            string? part = null,
            string? channelId = null,
            bool? mine = null,
            int? maxResults = null,
            string? pageToken = null,
            string? publishedAfter = null,
            string? publishedBefore = null,
            string? regionCode = null);
    }
}