using System.Collections.Generic;
using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    /// <summary>
    /// Requests for video interview workflows.
    /// </summary>
    public class ApplicantVideoInterviewRequests : HttpRequestMessage<IEnumerable<ApplicantVideoInterviewResponse>>
    {
        /// <summary>
        /// Request the video interviews for an applicant.
        /// </summary>
        /// <param name="applicantId"></param>
        public ApplicantVideoInterviewRequests(int applicantId) 
            : base(HttpMethod.Get, $"/Api/Applicant/{applicantId}/VideoInterviews")
        {
        }
    }
}
