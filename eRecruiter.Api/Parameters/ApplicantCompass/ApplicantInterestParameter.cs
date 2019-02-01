using System.Collections.Generic;

namespace eRecruiter.Api.Parameters
{
    /// <summary>
    /// Applicant Interests
    /// </summary>
    public class ApplicantInterestParameter
    {
        /// <summary>
        /// Answers for filter questions.
        /// </summary>
        public IEnumerable<ApplicantInterestFilterAnswer> Filters { get; set; }

        /// <summary>
        /// Answers for relevance questions.
        /// </summary>
        public IEnumerable<ApplicantInterestQuestionAnswer> Questions { get; set; }
    }
}
