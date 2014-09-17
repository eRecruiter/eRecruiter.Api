using System;

namespace eRecruiter.Api.Client
{
    /// <summary>
    /// Represents an bad request with http status code 400.
    /// </summary>
    public class BadRequestException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BadRequestException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public BadRequestException(string message = "Bad request (HTTP 400).") : base(message)
        {
        }
    }
}