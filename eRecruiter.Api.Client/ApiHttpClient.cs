using eRecruiter.Api.Client.Requests;
using eRecruiter.Api.Parameters;
using JetBrains.Annotations;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.Caching;
using System.Threading.Tasks;

namespace eRecruiter.Api.Client
{
    public class ApiHttpClient : HttpClient
    {
        private const int CacheDurationInSeconds = 60 * 30; // 30m cache duration
        private const int TimeoutInSeconds = 60;

        private readonly int _mandatorId;
        private readonly Stopwatch _watch;
        private readonly Func<ApiTokenCache> _apiTokenCacheFunction;
        
        public ApiHttpClient(
            [NotNull] Uri baseAddress,
            [NotNull] Func<ApiTokenParameter> apiKeyFunction,
            [NotNull] Func<ApiTokenCache> apiTokenCacheFunction)
            : base(new AuthorizationHandler(baseAddress, apiKeyFunction, apiTokenCacheFunction))
        {
            _apiTokenCacheFunction = apiTokenCacheFunction;
            _mandatorId = apiKeyFunction.Invoke().MandatorId;
            _watch = new Stopwatch();
            BaseAddress = new Uri(baseAddress.ToString().Trim('/'));
        }

        public long ElapsedMillisecondsInLastCall { get; private set; }
        public string LastReceivedContent { get; private set; }

        internal T SendAndRead<T>(HttpRequestMessage requestMessage, bool runTimer = true) where T : class
        {
            StartTimer(runTimer);

            try
            {
                var responseTask = SendAsync(requestMessage);
                responseTask.Wait();

                if (!responseTask.IsFaulted)
                {
                    var response = responseTask.Result;

                    LastReceivedContent = response.Content.ReadAsStringAsync().Result;
                    EnsureSuccessStatusCode(requestMessage, response);
                    var result = response.Content.ReadAsAsync<T>().Result;

                    return result;
                }

                throw new ApplicationException(string.Format("SendAsync with request '{0}' cancelled/timed out after {1} seconds.", requestMessage.GetType(), TimeoutInSeconds));
            }
            finally
            {
                EndTimer(runTimer);
            }
        }

        internal async Task<T> SendAndReadAsync<T>(HttpRequestMessage requestMessage, bool runTimer = true)
            where T : class
        {
            StartTimer(runTimer);

            var response = await SendAsync(requestMessage);
            LastReceivedContent = await response.Content.ReadAsStringAsync();
            EnsureSuccessStatusCode(requestMessage, response);
            var result = await response.Content.ReadAsAsync<T>();

            EndTimer(runTimer);
            return result;
        }

        private void EnsureSuccessStatusCode(HttpRequestMessage message, HttpResponseMessage response)
        {
            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (Exception)
            {
                var responseMessage = (LastReceivedContent ?? "").Trim(' ', '.');

                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    throw new NotFoundException("Resource at '" + message.RequestUri + "' not found (HTTP 404)" +
                                                (string.IsNullOrEmpty(responseMessage) ? "." : ": " + responseMessage + "."));
                }
                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    // we're unauthorized, this usually means that the token is expired but we still think it's not.
                    // so, lets clear the cache, so that at least the next request goes through
                    _apiTokenCacheFunction.Invoke().Clear(_mandatorId);

                    throw new UnauthorizedException("Unauthorized for resource at '" + message.RequestUri + "' (HTTP 401)" +
                                                    (string.IsNullOrEmpty(responseMessage) ? "." : ": " + responseMessage + "."));
                }
                if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    throw new BadRequestException("Bad request at '" + message.RequestUri + "' (HTTP 400)" +
                                                  (string.IsNullOrEmpty(responseMessage) ? "." : ": " + responseMessage + "."));
                }
                if (response.StatusCode == HttpStatusCode.InternalServerError)
                {
                    var serverError = JsonConvert.DeserializeObject<dynamic>(LastReceivedContent);
                    throw new ServerErrorException(("Server Error (HTTP 500). Exception on server: " + serverError.ExceptionMessage).Trim(' ', ':'));
                }
                throw;
            }
        }

        private void StartTimer(bool runTimer)
        {
            if (runTimer)
            {
                _watch.Reset();
                _watch.Start();
            }
        }

        private void EndTimer(bool runTimer)
        {
            if (runTimer)
            {
                _watch.Stop();
                ElapsedMillisecondsInLastCall = _watch.ElapsedMilliseconds;
            }
        }

        internal async Task<T> SendAndReadAsyncCached<T>(CachedHttpRequestMessage<T> requestMessage,
            TimeSpan cacheDuration) where T : class
        {
            _watch.Reset();
            _watch.Start();

            var cache = MemoryCache.Default;
            var cacheKey = _mandatorId + "_" + requestMessage.GetCacheKey();

            if (!cache.Contains(cacheKey))
                cache.Add(cacheKey, await SendAndReadAsync<T>(requestMessage, false),
                    DateTimeOffset.Now.Add(cacheDuration));
            else
                ElapsedMillisecondsInLastCall = 0;

            var result = cache.Get(cacheKey) as T;
            _watch.Stop();
            ElapsedMillisecondsInLastCall = _watch.ElapsedMilliseconds;

            return result;
        }

        internal async Task<T> SendAndReadAsyncCached<T>(CachedHttpRequestMessage<T> requestMessage) where T : class
        {
            return await SendAndReadAsyncCached(requestMessage, TimeSpan.FromSeconds(CacheDurationInSeconds));
        }

        public T SendAndReadCached<T>(CachedHttpRequestMessage<T> requestMessage) where T : class
        {
            return SendAndReadCached(requestMessage, TimeSpan.FromSeconds(CacheDurationInSeconds));
        }

        public T SendAndReadCached<T>(CachedHttpRequestMessage<T> requestMessage, TimeSpan cacheDuration) where T : class
        {
            _watch.Reset();
            _watch.Start();

            var cache = MemoryCache.Default;
            var cacheKey = _mandatorId + "_" + requestMessage.GetCacheKey();

            if (!cache.Contains(cacheKey))
                cache.Add(cacheKey, SendAndRead<T>(requestMessage, false),
                    DateTimeOffset.Now.Add(cacheDuration));
            else
                ElapsedMillisecondsInLastCall = 0;

            var result = cache.Get(cacheKey) as T;
            _watch.Stop();
            ElapsedMillisecondsInLastCall = _watch.ElapsedMilliseconds;

            return result;
        }
    }
}