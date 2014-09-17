namespace eRecruiter.Api.Parameters
{
    public class ApplicantCoverLetterCreateParameter
    {
        public ApplicantCoverLetterCreateParameter(int? jobId, string coverLetter)
        {
            JobId = jobId;
            CoverLetter = coverLetter;
        }

        public int? JobId { get; set; }
        public string CoverLetter { get; set; }
    }
}
