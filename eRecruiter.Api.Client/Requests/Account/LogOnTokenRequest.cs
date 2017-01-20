using System.Net.Http;
using eRecruiter.Api.Responses.Applicant;

namespace eRecruiter.Api.Client.Requests.Account
{
    /// <summary>
    /// Request to generate a log-on token for the applicant.
    /// </summary>
    public class LogOnTokenRequest : HttpRequestMessage<ApplicantLogOnTokenResponse>
    {
        public LogOnTokenRequest(int applicantId) : base(HttpMethod.Get, "Api/Applicant/" + applicantId + "/ResetPassword")
        {
        }
    }
}
