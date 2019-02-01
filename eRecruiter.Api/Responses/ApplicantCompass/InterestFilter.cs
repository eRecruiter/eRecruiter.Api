using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class InterestFilter
    {
        /// <summary>
        /// Filter ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The question text for the filter question.
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        /// The possible answers for the filter question.
        /// </summary>
        public IEnumerable<InterestFilterAnswer> Answers { get; set; }
    }
}
