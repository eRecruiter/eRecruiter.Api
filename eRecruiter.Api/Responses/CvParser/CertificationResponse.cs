using System;

namespace eRecruiter.Api.Responses
{
    /// <summary>
    /// Description of a certification
    /// </summary>
    public class CertificationResponse
    {
        /// <summary>
        /// Start date of the certification
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// End date of the certification
        /// </summary>
        public DateTime? EndDate { get; set; }
        
        /// <summary>
        /// Name of the certificate
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Code and name of the certificate
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Authory provided the certificate
        /// </summary>
        public string Authority { get; set; }
    }
}