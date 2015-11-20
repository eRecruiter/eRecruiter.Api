using System.Collections.Generic;
using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantExternalIdGetRequest : HttpRequestMessage<ApplicantExternalIdResponse>
    {
        public ApplicantExternalIdGetRequest(int externalId)
            : base(HttpMethod.Get, "Api/Applicant/ExternalId/" + externalId)
        {
        }
    }
}