using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class SetPasswordRequest : PostJsonHttpRequestMessage<ApplicantSetPasswordResponse>
    {
        public SetPasswordRequest(ApplicantSetPasswordAfterRequestParameter param)
            : base("Api/Applicant/SetPassword", param)
        {
        }

        public SetPasswordRequest(int applicantId, ApplicantSetPasswordParameter param)
            : base("Api/Applicant/" + applicantId + "/SetPassword", param)
        {
        }
    }
}
