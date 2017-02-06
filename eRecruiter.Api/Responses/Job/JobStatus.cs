namespace eRecruiter.Api.Responses
{
    /// <summary>
    /// Status for Jobs
    /// </summary>
    public enum JobStatus
    {
        /// <summary>
        /// The job is open.
        /// </summary>
        Open = 0,

        /// <summary>
        /// The job is a draft.
        /// </summary>
        Draft = 1,

        /// <summary>
        /// The job is closed with an engagement.
        /// </summary>
        Engaged = 2,

        /// <summary>
        /// The job is closed with a reposition.
        /// </summary>
        Repositioned = 3,

        /// <summary>
        /// The job is closed with a cancellation.
        /// </summary>
        Cancelled = 4,
    }
}
