using System.Net.Http;
using System.Threading.Tasks;

namespace eRecruiter.Api.Client.Requests
{
    public abstract class CachedHttpRequestMessage<T> : HttpRequestMessage<T> where T : class
    {
        protected CachedHttpRequestMessage(HttpMethod method, string requestUri) : base(method, requestUri) { }

        public abstract string GetCacheKey();

        public override async Task<T> LoadResultAsync(ApiHttpClient client)
        {
            return await client.SendAndReadAsyncCached(this);
        }

        public override T LoadResult(ApiHttpClient client)
        {
            return client.SendAndReadCached(this);
        }
    }
}
