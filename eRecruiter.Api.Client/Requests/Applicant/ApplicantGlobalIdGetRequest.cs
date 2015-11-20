using System.Collections.Generic;
using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantGlobalIdGetRequest : HttpRequestMessage<IEnumerable<ApplicantGlobalIdResponse>>
    {
        public ApplicantGlobalIdGetRequest(int globalId)
            : base(HttpMethod.Get, "Api/Applicant/GlobalId/" + globalId)
        {
        }
    }
}