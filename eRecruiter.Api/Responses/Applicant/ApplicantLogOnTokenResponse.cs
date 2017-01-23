using System;

namespace eRecruiter.Api.Responses
{
    /// <summary>
    /// Response for applicant log-on token requests.
    /// </summary>
    public class ApplicantLogOnTokenResponse
    {
        /// <summary>
        /// Applicant the log-on token has been issued for.
        /// </summary>
        public int ApplicantId { get; set; }

        /// <summary>
        /// The log-on token for the applicant.
        /// </summary>
        public string LogOnToken { get; set; }

        /// <summary>
        /// The expiration time for the log-on token.
        /// </summary>
        public DateTime ExpiresAt { get; set; }
    }
}
