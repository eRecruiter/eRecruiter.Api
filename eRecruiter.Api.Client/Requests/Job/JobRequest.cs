using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using System.Globalization;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class JobRequest : CachedHttpRequestMessage<JobResponse>
    {
        private readonly int _jobId;
        private readonly CultureInfo _culture;

        public JobRequest(int jobId, CultureInfo culture)
            : base(HttpMethod.Get, "Api/Job/" + jobId + "?culture=" + culture.Name)
        {
            _culture = culture;
            _jobId = jobId;
        }

        public JobRequest(int jobId)
            : this(jobId, CultureInfo.CurrentCulture)
        {
        }

        public override string GetCacheKey()
        {
            return "Job_" + _jobId + "_" + _culture;
        }
    }

    public class JobPostRequest : PostJsonHttpRequestMessage<JobCreationResponse>
    {
        /// <summary>
        /// Creates a new job
        /// </summary>
        /// <param name="job">The job.</param>
        public JobPostRequest(JobParameter job)
            : base("Api/Job/", job)
        {
        }
    }
}
