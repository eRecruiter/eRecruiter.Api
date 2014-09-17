using System.Globalization;
using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class PublishedJobsRequest : CachedHttpRequestMessage<JobsResponse>
    {
        private readonly string _channel;
        private readonly CultureInfo _culture;

        public PublishedJobsRequest(string channel, CultureInfo culture)
            : base(HttpMethod.Get, "Api/PublishedJobs?channel=" + channel + "&culture=" + culture.Name)
        {
            _culture = culture;
            _channel = channel;
        }

        public PublishedJobsRequest(string channel)
            : this(channel, CultureInfo.CurrentCulture)
        {
        }

        public override string GetCacheKey()
        {
            return "PublishedJobs_" + _channel + "_" + _culture.Name;
        }
    }
}
