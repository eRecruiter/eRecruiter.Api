using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class UnlinkXingRequest : HttpRequestMessage<ApplicantResponse>
    {
        public UnlinkXingRequest(int id)
            : base(HttpMethod.Delete, "Api/Applicant/Xing/" + id)
        {
        }
    }
}
