using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class ApplicationCreateResponse
    {
        public int? ApplicationId { get; set; }

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
