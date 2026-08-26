using Google.Apis.Auth.OAuth2;
using RestSharp;
using RestSharp.Interceptors;

namespace YouTubeSharp
{
    public class AuthorizationInterceptor : Interceptor
    {
        private readonly UserCredential credential;

        public AuthorizationInterceptor(UserCredential credential)
        {
            this.credential = credential;
        }

        public override async ValueTask BeforeRequest(RestRequest request, CancellationToken cancellationToken)
        {
            // This method is smart: it returns the current token if valid, 
            // or refreshes it automatically if expired.
            var token = await this.credential.GetAccessTokenForRequestAsync();

            request.AddHeader("Authorization", "Bearer " + token);
        }
    }
}
