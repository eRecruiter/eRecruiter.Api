using eRecruiter.Api.Responses;
using System;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class MandatorRequest : CachedHttpRequestMessage<MandatorResponse>
    {
        private readonly Uri _currentUri;

        public MandatorRequest(Uri currentUri)
            : base(HttpMethod.Get, "Api/Mandator?uri=" + currentUri)
        {
            _currentUri = currentUri;
        }

        public MandatorRequest()
            : base(HttpMethod.Get, "Api/Mandator")
        {
        }

        public override string GetCacheKey()
        {
            // ApiHttpClient automatically appends the Mandator ID to the cache key, so only caching with key 'MandatorRequest' is not a problem.
            return "MandatorRequest" + (_currentUri == null ? "" : "_" + _currentUri.Host);
        }
    }
}
