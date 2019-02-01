namespace eRecruiter.Api.Responses
{
    /// <summary>
    /// Job Insight Benefit
    /// </summary>
    public class JobInsightBenefit
    {
        /// <summary>
        /// Name of the benefit.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the benefit.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Icon of the benefit as Fontawesome 5 class name.
        /// </summary>
        public string Icon { get; set; }
    }
}
