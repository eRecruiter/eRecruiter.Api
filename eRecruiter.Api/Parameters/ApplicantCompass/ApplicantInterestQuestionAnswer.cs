namespace eRecruiter.Api.Parameters
{
    /// <summary>
    /// Answer to an interest question (relevance question).
    /// </summary>
    public class ApplicantInterestQuestionAnswer
    {
        /// <summary>
        /// Interest Question ID
        /// </summary>
        public int QuestionId { get; set; }

        /// <summary>
        /// Weight of the answer to the question.
        /// </summary>
        public double Answer { get; set; }
    }
}
