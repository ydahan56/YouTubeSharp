using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Newtonsoft.Json;
using Nito.AsyncEx;
using RestSharp;
using SimpleInjector;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using YouTubeSharp;
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

public class YouTubeClient
{
    public IActivities Activities { get; set; }
    public ICaptions Captions { get; set; }
    public IChannelBanners ChannelBanners { get; set; }
    public IChannels Channels { get; set; }
    public IChannelSections ChannelSections { get; set; }
    public IComments Comments { get; set; }
    public ICommentThreads CommentThreads { get; set; }
    public II18nLanguages I18NLanguages { get; set; }
    public II18nRegions I18NRegions { get; set; }
    public IMembers Members { get; set; }
    public IMembershipsLevels MembershipsLevels { get; set; }
    public IPlaylistImages PlaylistImages { get; set; }
    public IPlaylistItems PlaylistItems { get; set; }
    public IPlaylists Playlists { get; set; }
    public ISearch Search { get; set; }
    public ISubscriptions Subscriptions { get; set; }
    public IThumbnails Thumbnails { get; set; }
    public IVideoAbuseReportReasons VideoAbuseReportReasons { get; set; }
    public IVideoCategories VideoCategories { get; set; }
    public IVideos Videos { get; set; }
    public IWatermarks Watermarks { get; set; }

    private readonly Container simpleinjector;

    public YouTubeClient(string credentialsPath)
    {
        this.simpleinjector = new Container();

        UserCredential credential;
        using (var stream = new FileStream(credentialsPath, FileMode.Open, FileAccess.Read))
        {
            // The FileDataStore will create a folder named "YouTube.Auth.Store"
            // to store the retrieved Access/Refresh tokens after the first login.
            credential = AsyncContext.Run(async () =>
                await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    new[] { YouTubeService.Scope.YoutubeForceSsl },
                    "user",
                    CancellationToken.None,
                    new FileDataStore("YouTube.Auth.Store")
                )
            );
        }


        this.simpleinjector.RegisterSingleton<IRestClient>(() =>
        {
            var options = new RestClientOptions()
            {
                BaseUrl = new Uri("https://www.googleapis.com/youtube/v3"),
                Interceptors = new List<RestSharp.Interceptors.Interceptor>() {
                        new AuthorizationInterceptor(default)
                }
            };

            var http = new RestClient(options);
            http.AddDefaultQueryParameter("part", "snippet");
            http.AddDefaultQueryParameter("alt", "json");
            return http;
        });

        this.simpleinjector.RegisterSingleton<IActivities, TActivities>();
        this.simpleinjector.RegisterSingleton<ICaptions, TCaptions>();
        this.simpleinjector.RegisterSingleton<IChannelBanners, TChannelBanners>();
        this.simpleinjector.RegisterSingleton<IChannels, TChannels>();
        this.simpleinjector.RegisterSingleton<IChannelSections, TChannelSections>();
        this.simpleinjector.RegisterSingleton<IComments, TComments>();
        this.simpleinjector.RegisterSingleton<ICommentThreads, TCommentThreads>();
        this.simpleinjector.RegisterSingleton<II18nLanguages, TI18nLanguages>();
        this.simpleinjector.RegisterSingleton<II18nRegions, TI18nRegions>();
        this.simpleinjector.RegisterSingleton<IMembers, TMembers>();
        this.simpleinjector.RegisterSingleton<IMembershipsLevels, TMembershipsLevels>();
        this.simpleinjector.RegisterSingleton<IPlaylistImages, TPlaylistImages>();
        this.simpleinjector.RegisterSingleton<IPlaylistItems, TPlaylistItems>();
        this.simpleinjector.RegisterSingleton<IPlaylists, TPlaylists>();
        this.simpleinjector.RegisterSingleton<ISearch, TSearch>();
        this.simpleinjector.RegisterSingleton<ISubscriptions, TSubscriptions>();
        this.simpleinjector.RegisterSingleton<IThumbnails, TThumbnails>();
        this.simpleinjector.RegisterSingleton<IVideoAbuseReportReasons, TVideoAbuseReportReasons>();
        this.simpleinjector.RegisterSingleton<IVideoCategories, TVideoCategories>();
        this.simpleinjector.RegisterSingleton<IVideos, TVideos>();
        this.simpleinjector.RegisterSingleton<IWatermarks, TWatermarks>();

        // this.simpleinjector.Verify();

        this.Activities = this.simpleinjector.GetInstance<IActivities>();
        this.Captions = this.simpleinjector.GetInstance<ICaptions>();
        this.ChannelBanners = this.simpleinjector.GetInstance<IChannelBanners>();
        this.Channels = this.simpleinjector.GetInstance<IChannels>();
        this.ChannelSections = this.simpleinjector.GetInstance<IChannelSections>();
        this.Comments = this.simpleinjector.GetInstance<IComments>();
        this.CommentThreads = this.simpleinjector.GetInstance<ICommentThreads>();
        this.I18NLanguages = this.simpleinjector.GetInstance<II18nLanguages>();
        this.I18NRegions = this.simpleinjector.GetInstance<II18nRegions>();
        this.Members = this.simpleinjector.GetInstance<IMembers>();
        this.MembershipsLevels = this.simpleinjector.GetInstance<IMembershipsLevels>();
        this.PlaylistImages = this.simpleinjector.GetInstance<IPlaylistImages>();
        this.PlaylistItems = this.simpleinjector.GetInstance<IPlaylistItems>();
        this.Playlists = this.simpleinjector.GetInstance<IPlaylists>();
        this.Search = this.simpleinjector.GetInstance<ISearch>();
        this.Subscriptions = this.simpleinjector.GetInstance<ISubscriptions>();
        this.Thumbnails = this.simpleinjector.GetInstance<IThumbnails>();
        this.VideoAbuseReportReasons = this.simpleinjector.GetInstance<IVideoAbuseReportReasons>();
        this.VideoCategories = this.simpleinjector.GetInstance<IVideoCategories>();
        this.Videos = this.simpleinjector.GetInstance<IVideos>();
        this.Watermarks = this.simpleinjector.GetInstance<IWatermarks>();
    }
}