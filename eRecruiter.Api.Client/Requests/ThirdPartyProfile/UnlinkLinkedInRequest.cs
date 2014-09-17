using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class UnlinkLinkedInRequest : HttpRequestMessage<ApplicantResponse>
    {
        public UnlinkLinkedInRequest(int id)
            : base(HttpMethod.Delete, "Api/Applicant/LinkedIn/" + id)
        {
        }
    }
}
