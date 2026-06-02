using Google.Apis.Auth.OAuth2;
using Nito.AsyncEx;
using RestSharp;
using RestSharp.Interceptors;
using System;
using System.Collections.Generic;
using System.Text;

namespace YouTubeSharp
{
    public class AuthorizationInterceptor : Interceptor
    {
        private readonly ICredential credential;

        public AuthorizationInterceptor(ICredential credential)
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
