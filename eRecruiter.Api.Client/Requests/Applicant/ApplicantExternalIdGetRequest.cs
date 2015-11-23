using System.Collections.Generic;
using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantExternalIdGetRequest : HttpRequestMessage<IEnumerable<ApplicantResponse>>
    {
        public ApplicantExternalIdGetRequest(int externalId)
            : base(HttpMethod.Get, "Api/Applicants/ByExternalId/" + externalId)
        {
        }
    }
}