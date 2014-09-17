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
        private readonly Func<ApiKeyParameter> _apiKeyFunction;
        private readonly Uri _baseAddress;

        public AuthorizationHandler([NotNull] Uri baseAddress, [NotNull] Func<ApiKeyParameter> apiKeyFunction, [NotNull] Func<ApiTokenCache> apiCacheFunction)
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

            // 15 minutes buffer to make sure small time differences between server and client don't matter
            if (token == null || DateTime.UtcNow.AddMinutes(-15) >= token.Expires)
                token = RefreshApiToken(apiKey, tokenCache);

            if (InnerHandler == null)
                InnerHandler = new HttpClientHandler();
            if (token == null)
                throw new ApplicationException("Token is still null. This should not have happened.");
            request.Headers.Add("X-ApiToken", token.Token);
            return base.SendAsync(request, cancellationToken);
        }

        private ApiTokenResponse RefreshApiToken(ApiKeyParameter apiKeyParameter, ApiTokenCache tokenCache)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = _baseAddress;
                var request = client.SendAsync(new ApiKeyRequest(apiKeyParameter)).Result;

                request.EnsureSuccessStatusCode();

                var token = request.Content.ReadAsAsync<ApiTokenResponse>().Result;
                tokenCache.AddToken(apiKeyParameter.MandatorId, token);
                return token;
            }
        }
    }
}
