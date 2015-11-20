using System.Collections.Generic;
using eRecruiter.Api.Parameters;

namespace eRecruiter.Api.Responses
{
    public class ApplicantGlobalIdResponse : ApplicantGlobalIdParameters
    {
        public int ApplicantId { get; set; }

        public int MandatorId { get; set; }
    }
}
