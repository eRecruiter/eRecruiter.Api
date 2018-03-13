using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    /// <summary>
    /// Requests for a policy of an applicant
    /// </summary>
    public class ApplicantPolicyPutRequest : PutJsonHttpRequestMessage<ApplicantPolicyResponse>
    {
        /// <summary>
        /// Request for update a policy for an applicant
        /// </summary>
        /// <param name="applicantId"></param>
        /// <param name="policyId"></param>
        /// <param name="applicantPolicy"></param>
        public ApplicantPolicyPutRequest(int applicantId, int policyId, ApplicantPolicyParameter applicantPolicy)
            : base($"/Api/Applicant/{applicantId}/Policies/{policyId}", applicantPolicy)
        {
        }
    }
}
