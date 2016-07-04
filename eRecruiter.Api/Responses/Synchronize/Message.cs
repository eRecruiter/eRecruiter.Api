namespace eRecruiter.Api.Responses
{
    /// <summary>
    /// Respresenting a Message entry of a SyncResult
    /// </summary>
    public class Message
    {
        /// <summary>
        /// Message text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Message severity
        /// </summary>
        public Severity Severity { get; set; }
    }
}