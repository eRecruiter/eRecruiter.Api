using System;

namespace eRecruiter.Api.Client
{
    public class UnauthorizedException : Exception
    {
        public UnauthorizedException(string message = "Unauthorized (HTTP 401).") : base(message)
        {
        }
    }
}