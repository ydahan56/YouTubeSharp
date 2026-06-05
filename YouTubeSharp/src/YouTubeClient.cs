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

        // 1. Initialize the RestClient
        IRestClient httpClient = this.CreateRestClient(credential);

        // 2. Instantiate implementations directly using the 'new' keyword
        this.Activities = new TActivities(httpClient);
        this.Captions = new TCaptions(httpClient);
        this.ChannelBanners = new TChannelBanners(httpClient);
        this.Channels = new TChannels(httpClient);
        this.ChannelSections = new TChannelSections(httpClient);
        this.Comments = new TComments(httpClient);
        this.CommentThreads = new TCommentThreads(httpClient);
        this.I18NLanguages = new TI18nLanguages(httpClient);
        this.I18NRegions = new TI18nRegions(httpClient);
        this.Members = new TMembers(httpClient);
        this.MembershipsLevels = new TMembershipsLevels(httpClient);
        this.PlaylistImages = new TPlaylistImages(httpClient);
        this.PlaylistItems = new TPlaylistItems(httpClient);
        this.Playlists = new TPlaylists(httpClient);
        this.Search = new TSearch(httpClient);
        this.Subscriptions = new TSubscriptions(httpClient);
        this.Thumbnails = new TThumbnails(httpClient);
        this.VideoAbuseReportReasons = new TVideoAbuseReportReasons(httpClient);
        this.VideoCategories = new TVideoCategories(httpClient);
        this.Videos = new TVideos(httpClient);
        this.Watermarks = new TWatermarks(httpClient);
    }

    private IRestClient CreateRestClient(UserCredential credentials)
    {
        
        var options = new RestClientOptions()
        {
            BaseUrl = new Uri("httpClients://www.googleapis.com/youtube/v3"),
            Interceptors = new List<RestSharp.Interceptors.Interceptor>() {
                new AuthorizationInterceptor(credentials)
            }
        };

        var httpClient = new RestClient(options);
        httpClient.AddDefaultQueryParameter("part", "snippet");
        httpClient.AddDefaultQueryParameter("alt", "json");
        return httpClient;
    }
}