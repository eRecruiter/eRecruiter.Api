
namespace eRecruiter.Api.Parameters
{
    public class ApplicationCreateParameter
    {
        public ApplicationCreateParameter(int jobId, int applicantId)
        {
            JobId = jobId;
            ApplicantId = applicantId;
        }

        public int JobId { get; set; }
        public int ApplicantId { get; set; }

        public string Referrer { get; set; }
        public string ReferrerAdditionalInfo { get; set; }

        public bool RefreshApplicationIfItAlreadyExists { get; set; }
        public string CoverLetter { get; set; }
    }
}
