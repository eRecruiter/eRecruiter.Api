using System;

namespace eRecruiter.Api.Client
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message = "Not found (HTTP 404)") : base(message)
        {
        }
    }
}