using eRecruiter.Api.Responses;
using System.Collections.Generic;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    /// <summary>
    /// Requests for a policy
    /// </summary>
    public class PolicyGetRequest : HttpRequestMessage<PolicyResponse>
    {
        /// <summary>
        /// Request a specific policy
        /// </summary>
        /// <param name="policyId"></param>
        public PolicyGetRequest(int policyId) :
            base(HttpMethod.Get, "Api/Policies/" + policyId)
        {
        }
    }
}
