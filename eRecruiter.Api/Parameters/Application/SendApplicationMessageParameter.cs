namespace eRecruiter.Api.Parameters
{
    public class SendApplicationMessageParameter
    {
        public SendApplicationMessageParameter(int jobId, int applicantId)
        {
            JobId = jobId;
            ApplicantId = applicantId;
        }

        public int JobId { get; set; }
        public int ApplicantId { get; set; }
    }
}
