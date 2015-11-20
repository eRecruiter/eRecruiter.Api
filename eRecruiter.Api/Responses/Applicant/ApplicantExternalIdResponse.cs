using eRecruiter.Api.Parameters;

namespace eRecruiter.Api.Responses
{
    public class ApplicantExternalIdResponse : ApplicantExternalIdParameters
    {
        public int ApplicantId { get; set; }

        public int MandatorId { get; set; }
    }
}
