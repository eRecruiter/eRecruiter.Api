namespace eRecruiter.Api.Parameters
{
    /// <summary>
    /// Answer for a filter question.
    /// </summary>
    public class ApplicantInterestFilterAnswer
    {
        /// <summary>
        /// Interest Filter ID
        /// </summary>
        public int FilterId { get; set; }

        /// <summary>
        /// Interest Filter Answer ID
        /// </summary>
        public int AnswerId { get; set; }
    }
}
