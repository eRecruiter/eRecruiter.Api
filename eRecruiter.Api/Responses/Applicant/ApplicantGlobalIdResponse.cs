using System.Collections.Generic;
using eRecruiter.Api.Parameters;

namespace eRecruiter.Api.Responses
{
    public class ApplicantGlobalIdResponse : ApplicantGlobalIdParameters
    {
        public IEnumerable<int> ApplicantIds { get; set; }
    }
}
