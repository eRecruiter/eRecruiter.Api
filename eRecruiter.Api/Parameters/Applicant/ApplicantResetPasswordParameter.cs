using System;

namespace eRecruiter.Api.Parameters
{
    public class ApplicantResetPasswordParameter
    {
        public ApplicantResetPasswordParameter(string newPassword, Uri url)
        {
            NewPassword = newPassword;
            Url = url;
        }

        public string NewPassword { get; set; }
        public Uri Url { get; set; }
    }
}
