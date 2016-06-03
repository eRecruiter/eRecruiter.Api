using System.Collections.Generic;
using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantGlobalIdGetRequest : HttpRequestMessage<IEnumerable<ApplicantResponse>>
    {
        public ApplicantGlobalIdGetRequest(long globalId)
            : base(HttpMethod.Get, "Api/Applicants/ByGlobalId/" + globalId)
        {
        }
    }
}