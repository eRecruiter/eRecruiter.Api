using eRecruiter.Api.Responses;
using System.Collections.Generic;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    /// <summary>
    /// Requests for policies of an applicant
    /// </summary>
    public class ApplicantPoliciesGetRequest : HttpRequestMessage<IEnumerable<ApplicantPolicyResponse>>
    {
        /// <summary>
        /// Request the latest policies for an applicant
        /// </summary>
        /// <param name="applicantId"></param>
        public ApplicantPoliciesGetRequest(int applicantId)
            : base(HttpMethod.Get, $"/Api/Applicant/{applicantId}/Policies")
        {
        }
    }
}
