namespace eRecruiter.Api.Responses
{
    /// <summary>
    /// Response-Body parameters of CompanySynchronizeResponse
    /// </summary>
    public class CompanySynchronizeResponse
    {
        /// <summary>
        /// Flag parameter holding status information about the general success.
        /// </summary>
        public StatusType Status;

        /// <summary>
        /// Result root object
        /// </summary>
        public SyncResult Result { get; set; }
    }
}
