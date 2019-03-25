using System;

namespace eRecruiter.Api.Responses
{
    /// <summary>
    /// Job Publication Metadata
    /// </summary>
    public class JobPublicationResponse
    {
        #region Properties

        /// <summary>
        /// Publication channel name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Internal Name
        /// </summary>
        public string InternalName { get; set; }

        /// <summary>
        /// Multi-Posting partner (MPP-only)
        /// </summary>
        public string Partner { get; set; }

        /// <summary>
        /// Multi-Posting account (MPP-only)
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// Multi-Posting channel (MPP-only)
        /// </summary>
        public int? Channel { get; set; }

        /// <summary>
        /// Publication date for channel
        /// </summary>
        public DateTime PublicationDate { get; set; }

        /// <summary>
        /// Expiration date for channel
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Job publication type
        /// </summary>
        public JobPublicationType Type { get; set; }

        /// <summary>
        /// URL override for Job Ad. The placeholder $Referrer$ may be contained
        /// in the URL which needs to be replaced or removed.
        /// </summary>
        public string JobAdUrl { get; set; }

        /// <summary>
        /// URL override for registration/application. The placeholder $Referrer$
        /// may be contained in the URL which needs to be replaced or removed.
        /// </summary>
        public string ApplyUrl { get; set; }

        #endregion

        #region Types

        /// <summary>
        /// Job Publication Type
        /// </summary>
        public enum JobPublicationType
        {
            /// <summary>
            /// Portal Publication
            /// </summary>
            Portal,

            /// <summary>
            /// Channel Publication
            /// </summary>
            Channel,

            /// <summary>
            /// Multi-Posting Channel Publication
            /// </summary>
            MultiPostChannel
        }

        #endregion
    }
}