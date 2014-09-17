using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class JobsResponse
    {
        public IEnumerable<JobResponse> Jobs { get; set; }
        public string Channel { get; set; }
        public string Culture { get; set; }
    }
}
