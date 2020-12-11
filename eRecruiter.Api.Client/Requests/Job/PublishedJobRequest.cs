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
        private readonly bool _indeedWidgetEnabled;

        public PublishedJobRequest(int jobId, string channel, CultureInfo culture, bool indeedWidgetEnabled = false)
            : base(HttpMethod.Get, "Api/PublishedJob/" + jobId + "?channel=" + channel + "&culture=" + culture.Name + "&indeedWidgetEnabled=" + indeedWidgetEnabled)
        {
            _culture = culture;
            _channel = channel;
            _jobId = jobId;
            _indeedWidgetEnabled = indeedWidgetEnabled;
        }

        public PublishedJobRequest(int jobId, string channel, bool indeedWidgetEnabled = false)
            : this(jobId, channel, CultureInfo.CurrentCulture, indeedWidgetEnabled)
        {
        }

        public PublishedJobRequest(int jobId, bool indeedWidgetEnabled = false)
            : this(jobId, "", indeedWidgetEnabled)
        {
        }

        public override string GetCacheKey()
        {
            return "PublishedJob_" + _jobId + "_" + _channel + "_" + _culture + "_" + _indeedWidgetEnabled;
        }
    }
}
