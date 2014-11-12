using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using System;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class MandatorRequest : CachedHttpRequestMessage<MandatorResponse>
    {
        private readonly Uri _currentUri;
        private int? _currentMandatorId;

        public MandatorRequest(Uri currentUri)
            : base(HttpMethod.Get, "Api/Mandator?uri=" + currentUri)
        {
            _currentUri = currentUri;
        }

        public MandatorRequest()
            : base(HttpMethod.Get, "Api/Mandator")
        {
        }

        public MandatorRequest(int currentMandatorId)
            : base(HttpMethod.Get, "Api/Mandator/" + currentMandatorId)
        {
            _currentMandatorId = currentMandatorId;
        }


        public override string GetCacheKey()
        {
            // ApiHttpClient automatically appends the Mandator ID to the cache key, so only caching with key 'MandatorRequest' is not a problem.
            return "MandatorRequest" +
                   (_currentUri == null ? "" : "_" + _currentUri.Host) +
                   (_currentMandatorId.HasValue ? "_" + _currentMandatorId.Value : "");
        }
    }

    public class MandatorPutRequest : PutJsonHttpRequestMessage<MandatorResponse>
    {
        public MandatorPutRequest(MandatorCreateParameter mandator)
            : base("Api/Mandator/", mandator)
        {
        }
    }

    public class MandatorPostRequest : PostJsonHttpRequestMessage<MandatorResponse>
    {
        public MandatorPostRequest(int mandatorId, MandatorUpdateParameter mandator)
            : base("Api/Mandator/" + mandatorId, mandator)
        {
        }
    }

    public class MandatorDeleteRequest : HttpRequestMessage<MandatorResponse>
    {
        public MandatorDeleteRequest(int mandatorId)
            : base(HttpMethod.Delete, "Api/Mandator/" + mandatorId)
        {
        }
    }
}
