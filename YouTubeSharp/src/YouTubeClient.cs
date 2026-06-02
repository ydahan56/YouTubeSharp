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
using YouTubeSharp.PlaylistItems;
using YouTubeSharp.Search;

namespace YouTubeWorker.Infrastructure
{
    public class YouTubeClient
    {
        public IPlaylistItems PlaylistItems { get; set; }
      // public ISearch Search { get; set; }


        public Container simpleinjector { get; set; }
 

        public YouTubeClient(string credentialsPath)
        {
            this.simpleinjector = new Container();

            //UserCredential credential;

            //using (var stream = new FileStream(credentialsPath, FileMode.Open, FileAccess.Read))
            //{
            //    // The FileDataStore will create a folder named "YouTube.Auth.Store"
            //    // to store the retrieved Access/Refresh tokens after the first login.
            //    credential = AsyncContext.Run(async () =>
            //        await GoogleWebAuthorizationBroker.AuthorizeAsync(
            //            GoogleClientSecrets.FromStream(stream).Secrets,
            //            new[] { YouTubeService.Scope.YoutubeForceSsl },
            //            "user",
            //            CancellationToken.None,
            //            new FileDataStore("YouTube.Auth.Store")
            //        )
            //    );
            //}


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

            this.simpleinjector.RegisterSingleton<IPlaylistItems>(() => this.PlaylistItems);
           // this.simpleinjector.RegisterInstance<ISearch>(this.Search);

            this.simpleinjector.Verify();
        }
    }
}
