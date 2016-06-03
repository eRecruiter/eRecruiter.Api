using System.Collections.Generic;
using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class AgnosticApplicantsByGlobalIdRequest : HttpRequestMessage<IEnumerable<AgnosticApplicantsResponse>>
    {
        public AgnosticApplicantsByGlobalIdRequest(long globalId)
            : base(HttpMethod.Get, "/Api/Agnostic/Applicants/ByGlobalId/" + globalId)
        {
        }
    }
}