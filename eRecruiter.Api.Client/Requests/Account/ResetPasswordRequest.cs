using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class ResetPasswordRequest : PostJsonHttpRequestMessage<ApplicantSetPasswordResponse>
    {
        public ResetPasswordRequest(int applicantId, ApplicantResetPasswordParameter param)
            : base("Api/Applicant/" + applicantId + "/ResetPassword", param)
        {
        }
    }
}
