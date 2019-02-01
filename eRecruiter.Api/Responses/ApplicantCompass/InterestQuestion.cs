namespace eRecruiter.Api.Responses
{
    /// <summary>
    /// A question in the compass questionnaire.
    /// </summary>
    public class InterestQuestion
    {
        /// <summary>
        /// Question ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Question Text
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        /// The question icon based on Fontawesome 5 styles.
        /// </summary>
        public string Icon { get; set; }
    }
}
