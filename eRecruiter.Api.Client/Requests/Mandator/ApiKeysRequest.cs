using System.Collections.Generic;
using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class ApiKeysRequest : HttpRequestMessage<IEnumerable<ApiKeyResponse>>
    {
        /// <summary>
        /// Returns all API keys for the current mandator.
        /// </summary>
        public ApiKeysRequest()
            : base(HttpMethod.Get, "Api/Mandator/ApiKeys/")
        {
        }

        /// <summary>
        /// Returns all API keys for a specific mandator.
        /// </summary>
        /// <param name="mandatorId">The ID of the mandator.</param>
        public ApiKeysRequest(int mandatorId)
            : base(HttpMethod.Get, "Api/Mandator/" + mandatorId + "/ApiKeys/")
        {
        }
    }
}
