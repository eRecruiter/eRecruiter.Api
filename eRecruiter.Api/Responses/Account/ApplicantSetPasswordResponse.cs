using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class ApplicantSetPasswordResponse
    {
        public IEnumerable<Error> Errors { get; set; }

        public enum Error
        {
            PasswordPolicySymbols,
            PasswordPolicyNumeric,
            PasswordPolicyUppercase,
            PasswordPolicyLength,
            InvalidCode,
            InvalidOldPassword,
            PasswordPolicyContainsAccountName,
            PasswordPolicyInBannedList,
            PasswordPolicySameCharacterInRow,
            PasswordPolicyReuseOfOldPasswords
        }
    }
}
