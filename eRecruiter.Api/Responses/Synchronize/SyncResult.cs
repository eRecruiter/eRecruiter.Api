using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    /// <summary>
    /// Represents a result of the synchronization of a data object
    /// </summary>
    public class SyncResult
    {
        /// <summary>
        /// Identifies the data object
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// Entity name of data synchronized
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Messages occured during synchronization
        /// </summary>
        public IEnumerable<Message> Messages { get; set; }

        /// <summary>
        /// Related nested results
        /// </summary>
        public IEnumerable<SyncResult> NestedResults { get; set; }
    }
}