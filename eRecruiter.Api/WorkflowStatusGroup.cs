namespace eRecruiter.Api
{
    /// <summary>
    /// Workflow Status Group
    /// </summary>
    public enum WorkflowStatusGroup
    {
        /// <summary>
        /// Status group for applicants with unknown/confidential status.
        /// </summary>
        None,

        /// <summary>
        /// Applicants that just applied.
        /// </summary>
        New,

        /// <summary>
        /// Applicants that are under internal review.
        /// </summary>
        Internal,

        /// <summary>
        /// Applicants that have been proposed for external review.
        /// </summary>
        Proposed,

        /// <summary>
        /// Applicants that are under external review.
        /// </summary>
        External,

        /// <summary>
        /// Applicants that have been rejected.
        /// </summary>
        Rejected,

        /// <summary>
        /// Applicants that have been accepted/hired.
        /// </summary>
        Accepted
    }
}
