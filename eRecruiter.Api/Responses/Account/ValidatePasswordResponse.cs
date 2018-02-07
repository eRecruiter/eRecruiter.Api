using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class ValidatePasswordResponse
    {
        public IEnumerable<Error> Errors { get; set; }

        public enum Error
        {
            PasswordPolicySymbols,
            PasswordPolicyNumeric,
            PasswordPolicyUppercase,
            PasswordPolicyLength
        }
    }
}
