namespace eRecruiter.Api
{
    /// <summary>
    /// The poosible types of a history entry.
    /// </summary>
    public enum HistoryType
    {
        /// <summary>
        /// A manually (mostly by a user) created history entry.
        /// </summary>
        Manual,
        /// <summary>
        /// The history entry was created during an import.
        /// </summary>
        Import
    }
}
