using eRecruiter.Api.Responses.Cache;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class InvalidCachedKeyRequest : HttpRequestMessage<InvalidCacheKeyResponse>
    {
        public InvalidCachedKeyRequest(string key)
            : base(HttpMethod.Get, "Api/Cache/IsInvalidKey?key=" + key)
        {

        }
    }
}