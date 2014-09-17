using System;
using System.Net.Http;
using eRecruiter.Api.Responses;

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

        public override string GetCacheKey()
        {
            return "MandatorRequest_" + _currentUri.Host;
        }
    }
}
