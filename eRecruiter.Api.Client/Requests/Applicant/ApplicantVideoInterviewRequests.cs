using System.Collections.Generic;
using System.Net.Http;
using eRecruiter.Api.Parameters;
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

    /// <summary>
    /// Creates video interview.
    /// </summary>
    public class ApplicantVideoInterviewPutRequest : PutJsonHttpRequestMessage<ApplicantVideoInterviewResponse>
    {
        /// <summary>
        /// Creates video interview for applicant.
        /// </summary>
        /// <param name="applicantId"></param>
        /// <param name="applicantVideoInterviewParameter"></param>
        public ApplicantVideoInterviewPutRequest(int applicantId, ApplicantVideoInterviewParameter applicantVideoInterviewParameter)
            : base($"/Api/Applicant/{applicantId}/VideoInterviews", applicantVideoInterviewParameter)
        {
        }
    }
}
