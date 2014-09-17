using System;

namespace eRecruiter.Api.Client
{
    public class ServerErrorException : Exception
    {
        public ServerErrorException(string message = "Server error (HTTP 500).") : base(message)
        {
        }
    }
}