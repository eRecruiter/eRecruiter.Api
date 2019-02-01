namespace eRecruiter.Api.Responses
{
    /// <summary>
    /// Interest Profile
    /// </summary>
    public class InterestProfileResponse
    {
        /// <summary>
        /// ID of the interest profile.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ID of the speculative job.
        /// </summary>
        public int SpeculativeJobId { get; set; }

        /// <summary>
        /// ID of the job insight.
        /// </summary>
        public int JobInsightId { get; set; }
    }
}
