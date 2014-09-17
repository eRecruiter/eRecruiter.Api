using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class ApplicationCreateResponse
    {
        public IEnumerable<Error> Errors { get; set; }

        public enum Error
        {
            ApplicationAlreadyExists,
            JobIsClosed,
            JobDoesNotExist,
            ApplicantDoesNotExist
        }
    }
}
