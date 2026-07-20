using YouTubeSharp.Activities;
using YouTubeSharp.Captions;
using YouTubeSharp.ChannelBanners;
using YouTubeSharp.Channels;
using YouTubeSharp.ChannelSections;
using YouTubeSharp.Comments;
using YouTubeSharp.CommentThreads;
using YouTubeSharp.I18nLanguages;
using YouTubeSharp.I18nRegions;
using YouTubeSharp.Members;
using YouTubeSharp.MembershipsLevels;
using YouTubeSharp.PlaylistImages;
using YouTubeSharp.PlaylistItems;
using YouTubeSharp.Playlists;
using YouTubeSharp.Search;
using YouTubeSharp.Subscriptions;
using YouTubeSharp.Thumbnails;
using YouTubeSharp.VideoAbuseReportReasons;
using YouTubeSharp.VideoCategories;
using YouTubeSharp.Videos;
using YouTubeSharp.Watermarks;

namespace YouTubeSharp;

public interface IYouTubeClient
{
    IActivities Activities { get; set; }
    ICaptions Captions { get; set; }
    IChannelBanners ChannelBanners { get; set; }
    IChannels Channels { get; set; }
    IChannelSections ChannelSections { get; set; }
    IComments Comments { get; set; }
    ICommentThreads CommentThreads { get; set; }
    II18nLanguages I18NLanguages { get; set; }
    II18nRegions I18NRegions { get; set; }
    IMembers Members { get; set; }
    IMembershipsLevels MembershipsLevels { get; set; }
    IPlaylistImages PlaylistImages { get; set; }
    IPlaylistItems PlaylistItems { get; set; }
    IPlaylists Playlists { get; set; }
    ISearch Search { get; set; }
    ISubscriptions Subscriptions { get; set; }
    IThumbnails Thumbnails { get; set; }
    IVideoAbuseReportReasons VideoAbuseReportReasons { get; set; }
    IVideoCategories VideoCategories { get; set; }
    IVideos Videos { get; set; }
    IWatermarks Watermarks { get; set; }
}
