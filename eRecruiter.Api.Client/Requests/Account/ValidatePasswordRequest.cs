using System;
using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    /// <summary>
    /// Request to validate a password against the password policy.
    /// </summary>
    public class ValidatePasswordRequest : HttpRequestMessage<ValidatePasswordResponse>
    {
        public ValidatePasswordRequest(string passwordToValidate, Uri currentUri) 
            : base(HttpMethod.Get, $"Api/Validation/Password?password={passwordToValidate}&uri={currentUri}")
        {
        }
    }
}
