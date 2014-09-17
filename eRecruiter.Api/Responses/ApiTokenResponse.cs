using System;

namespace eRecruiter.Api.Responses
{
    public class ApiTokenResponse
    {
        public string Token { get; set; }
        public DateTime Expires { get; set; }
    }
}
