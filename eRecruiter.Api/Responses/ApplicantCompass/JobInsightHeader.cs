namespace eRecruiter.Api.Responses
{
    /// <summary>
    /// Header information for job insight.
    /// </summary>
    public class JobInsightHeader
    {
        /// <summary>
        /// Title of the job insight.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Text of the job insight.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Image URL for the header.
        /// </summary>
        public string HeaderImageUrl { get; set; }

        /// <summary>
        /// Video URL for the header.
        /// </summary>
        public string HeaderVideoUrl { get; set; }
    }
}
