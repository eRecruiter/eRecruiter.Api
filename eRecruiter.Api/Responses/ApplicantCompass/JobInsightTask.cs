namespace eRecruiter.Api.Responses
{
    /// <summary>
    /// Job Insight Task
    /// </summary>
    public class JobInsightTask
    {
        /// <summary>
        /// The title that should be displayed.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The description text for the task.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The image that should be displayed as background.
        /// </summary>
        public byte[] Image { get; set; }
    }
}
