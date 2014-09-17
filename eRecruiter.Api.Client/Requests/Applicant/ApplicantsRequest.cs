using System.Collections.Generic;
using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantsRequest : HttpRequestMessage<IEnumerable<ApplicantResponse>>
    {
        public ApplicantsRequest(string email)
            : base(HttpMethod.Get, "Api/Applicants/ByEmail/" + email)
        {
        }
    }
}
