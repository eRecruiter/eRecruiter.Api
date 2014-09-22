using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class JobsResponse
    {
        public IEnumerable<JobResponse> Jobs { get; set; }
        public JobPublicationResponse JobPublicationType { get; set; }
        public string Culture { get; set; }
    }
}
