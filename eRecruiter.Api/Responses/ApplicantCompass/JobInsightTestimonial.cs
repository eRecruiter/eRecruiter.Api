namespace eRecruiter.Api.Responses.ApplicantCompass
{
    /// <summary>
    /// Job Insight Testimonial
    /// </summary>
    public class JobInsightTestimonial
    {
        /// <summary>
        /// Name of the person giving the testimonial.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Position of the person giving the testimonial.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// A statement of the person giving the testimonial.
        /// </summary>
        public string Statement { get; set; }

        /// <summary>
        /// Additional text from the person giving the testimonial.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The image that should be displayed as avatar.
        /// </summary>
        public byte[] Image { get; set; }
    }
}
