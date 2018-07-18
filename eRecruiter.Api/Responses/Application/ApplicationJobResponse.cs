namespace eRecruiter.Api.Responses
{
    /// <summary>
    /// Response for an application based on job.
    /// </summary>
    public class ApplicationJobResponse
    {
        /// <summary>
        /// Application ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Job ID
        /// </summary>
        public int JobId { get; set; }

        /// <summary>
        /// Applicant ID
        /// </summary>
        public int ApplicantId { get; set; }
    }
}
