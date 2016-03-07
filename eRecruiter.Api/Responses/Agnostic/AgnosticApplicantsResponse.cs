using System;

namespace eRecruiter.Api.Responses
{
    /// <summary>
    /// Response for mandator-agnostic applicant retrieval by global identifiers.
    /// </summary>
    public class AgnosticApplicantsResponse
    {
        /// <summary>
        /// Applicant ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Mandator ID
        /// </summary>
        public int MandatorId { get; set; }

        /// <summary>
        /// Date of last update by applicant
        /// </summary>
        public DateTime? LastUpdated { get; set; }
    }
}
