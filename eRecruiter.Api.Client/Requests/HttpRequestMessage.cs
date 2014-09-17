using System.Net.Http;
using System.Threading.Tasks;

namespace eRecruiter.Api.Client.Requests
{
    public abstract class HttpRequestMessage<T> : HttpRequestMessage where T : class
    {
        protected HttpRequestMessage(HttpMethod method, string requestUri) : base(method, requestUri) { }

        public virtual async Task<T> LoadResultAsync(ApiHttpClient client)
        {
            return await client.SendAndReadAsync<T>(this);
        }

        public virtual T LoadResult(ApiHttpClient client)
        {
            return client.SendAndRead<T>(this);
        }
    }
}
