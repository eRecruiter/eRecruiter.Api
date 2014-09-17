using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class ConfirmRequestPasswordRequest : HttpRequestMessage<ApplicantResponse>
    {
        public ConfirmRequestPasswordRequest(string email, string code)
            : base(HttpMethod.Get, "Api/Applicant?email=" + email + "&code=" + code)
        {
        }
    }
}
