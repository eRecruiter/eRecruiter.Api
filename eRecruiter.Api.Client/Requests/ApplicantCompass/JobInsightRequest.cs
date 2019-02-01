using eRecruiter.Api.Responses;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    /// <summary>
    /// Request to fetch job insight information.
    /// </summary>
    public class JobInsightRequest : HttpRequestMessage<JobInsightResponse>
    {
        /// <summary>
        /// Fetch a job insight for the current culture.
        /// </summary>
        /// <param name="jobInsightId">Job Insight ID</param>
        public JobInsightRequest(int jobInsightId) : this(jobInsightId, CultureInfo.CurrentUICulture.Name)
        {
        }

        /// <summary>
        /// Fetch a job insight for the provided culture.
        /// </summary>
        /// <param name="jobInsightId">Job Insight ID</param>
        /// <param name="culture">Culture Name</param>
        public JobInsightRequest(int jobInsightId, string culture) : base(HttpMethod.Get, $"/ApplicantCompass/JobInsight/{jobInsightId}?culture={culture}")
        {
        }
    }
}
