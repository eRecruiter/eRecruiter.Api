using System.Globalization;
using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class PublishedJobRequest : CachedHttpRequestMessage<JobResponse>
    {
        private readonly int _jobId;
        private readonly string _channel;
        private readonly CultureInfo _culture;

        public PublishedJobRequest(int jobId, string channel, CultureInfo culture)
            : base(HttpMethod.Get, "Api/PublishedJob/" + jobId + "?channel=" + channel + "&culture=" + culture.Name)
        {
            _culture = culture;
            _channel = channel;
            _jobId = jobId;
        }

        public PublishedJobRequest(int jobId, string channel)
            : this(jobId, channel, CultureInfo.CurrentCulture)
        {
        }

        public PublishedJobRequest(int jobId)
            : this(jobId, "")
        {
        }

        public override string GetCacheKey()
        {
            return "PublishedJob_" + _jobId + "_" + _channel + "_" + _culture;
        }
    }
}
