using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    /// <summary>
    /// A group of interest questions.
    /// </summary>
    public class InterestQuestionGroup
    {
        /// <summary>
        /// The name of the group.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The question in the question group.
        /// </summary>
        public IEnumerable<InterestQuestion> Questions { get; set; }
    }
}
