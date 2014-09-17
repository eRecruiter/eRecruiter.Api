using System;

namespace eRecruiter.Api.Parameters
{
    public class ApplicantSetPasswordParameter
    {
        public ApplicantSetPasswordParameter(string oldPassword, string newPassword, Uri url)
        {
            OldPassword = oldPassword;
            NewPassword = newPassword;
            Url = url;
        }

        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public Uri Url { get; set; }
    }
}
