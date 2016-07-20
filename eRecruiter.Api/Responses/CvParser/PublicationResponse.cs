using System;

namespace eRecruiter.Api.Responses
{
    /// <summary>
    /// Description of a publication
    /// </summary>
    public class PublicationResponse
    {
        /// <summary>
        /// Publication title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Publication date
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Abstract of the publication
        /// </summary>
        public string Abstract { get; set; }

        /// <summary>
        /// Kind of publication
        /// </summary>
        public string PublicationType { get; set; }

        /// <summary>
        /// URL to publication
        /// </summary>
        public string Url { get; set; }
    }
}