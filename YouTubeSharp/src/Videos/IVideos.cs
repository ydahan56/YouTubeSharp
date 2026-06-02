using RestSharp;
using YouTubeSharp.Videos.Models.Request;
using YouTubeSharp.Videos.Models.Response;

namespace YouTubeSharp.Videos
{
    public interface IVideos
    {
        /// <summary>
        /// Returns a list of videos that match the API request parameters.
        /// </summary>
        RestResponse<VideoListResponse> List(VideosListRequest requestModel);

        /// <summary>
        /// Uploads a video to YouTube and optionally sets video metadata.
        /// </summary>
        RestResponse<Video> Insert(VideosInsertRequest requestModel);

        /// <summary>
        /// Updates a video's metadata.
        /// </summary>
        RestResponse<Video> Update(VideosUpdateRequest requestModel);

        /// <summary>
        /// Deletes a YouTube video.
        /// </summary>
        RestResponse Delete(VideosDeleteRequest requestModel);
    }
}