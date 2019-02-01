namespace eRecruiter.Api.Responses
{
    /// <summary>
    /// Answer for an interest filter.
    /// </summary>
    public class InterestFilterAnswer
    {
        /// <summary>
        /// Answer ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The answer text for the interest filter.
        /// </summary>
        public string Answer { get; set; }

        /// <summary>
        /// The icon for the answer based on Fontawesome 5 style classes.
        /// </summary>
        public string Icon { get; set; }
    }
}
