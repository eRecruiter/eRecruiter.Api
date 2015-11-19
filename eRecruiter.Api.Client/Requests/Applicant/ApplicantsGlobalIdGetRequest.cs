using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantsGlobalIdGetRequest : HttpRequestMessage<ApplicantGlobalIdResponse>
    {
        public ApplicantsGlobalIdGetRequest(int globalId)
            : base(HttpMethod.Get, "Api/Applicant/GlobalId/" + globalId)
        {
        }
    }
}
