using eRecruiter.Api.Responses;
using System.Collections.Generic;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    /// <summary>
    /// Request for policies
    /// </summary>
    public class PoliciesGetRequest : HttpRequestMessage<IEnumerable<PolicyResponse>>
    {
        /// <summary>
        /// Returns the current version of each type of Policy
        /// </summary>
        public PoliciesGetRequest()
            : base(HttpMethod.Get, "Api/Policies/")
        {
        }
    }
}
