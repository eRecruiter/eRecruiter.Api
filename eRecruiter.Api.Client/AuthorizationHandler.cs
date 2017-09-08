using eRecruiter.Api.Client.Requests;
using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using JetBrains.Annotations;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using HttpRequestMessage = System.Net.Http.HttpRequestMessage;

namespace eRecruiter.Api.Client
{
    public class AuthorizationHandler : DelegatingHandler
    {
        private readonly Func<ApiTokenCache> _apiCacheFunction;
        private readonly Func<ApiTokenParameter> _apiKeyFunction;
        private readonly Uri _baseAddress;

        public AuthorizationHandler([NotNull] Uri baseAddress, [NotNull] Func<ApiTokenParameter> apiKeyFunction, [NotNull] Func<ApiTokenCache> apiCacheFunction)
        {
            _baseAddress = baseAddress;
            _apiCacheFunction = apiCacheFunction;
            _apiKeyFunction = apiKeyFunction;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var apiKey = _apiKeyFunction.Invoke();
            var tokenCache = _apiCacheFunction.Invoke();

            var token = tokenCache.GetCachedToken(apiKey.MandatorId);

            // renew the token 30 minutes before it's expiration
            if (token == null || DateTime.UtcNow.AddMinutes(-30) >= token.Expires)
                token = RefreshApiToken(apiKey, tokenCache);

            if (InnerHandler == null)
                InnerHandler = new HttpClientHandler();
            if (token == null)
                throw new ApplicationException("Token is still null. This should not have happened.");
            request.Headers.Add("X-ApiToken", token.Token);
            return base.SendAsync(request, cancellationToken);
        }

        private ApiTokenResponse RefreshApiToken(ApiTokenParameter apiTokenParameter, ApiTokenCache tokenCache)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = _baseAddress;
                var request = client.SendAsync(new ApiKeyRequest(apiTokenParameter)).Result;

                request.EnsureSuccessStatusCode();

                var token = request.Content.ReadAsAsync<ApiTokenResponse>().Result;
                tokenCache.AddToken(apiTokenParameter.MandatorId, token);
                return token;
            }
        }
    }
}
