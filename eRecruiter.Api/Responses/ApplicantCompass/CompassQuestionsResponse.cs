using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class CompassQuestionsResponse
    {
        /// <summary>
        /// Filter Criteria
        /// </summary>
        public IEnumerable<InterestFilter> Filters { get; set; }

        /// <summary>
        /// Relevance Criteria
        /// </summary>
        public IEnumerable<InterestQuestionGroup> Groups { get; set; }
    }
}
