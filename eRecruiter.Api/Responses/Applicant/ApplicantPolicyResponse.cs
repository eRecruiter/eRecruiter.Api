using System;
using eRecruiter.Api.Responses.Policies;

namespace eRecruiter.Api.Responses
{
    /// <summary>
    /// A policy that has been read/accepted/revoked by the applicant.
    /// </summary>
    public class ApplicantPolicyResponse
    {
        /// <summary>
        /// Applicant ID
        /// </summary>
        public int ApplicantId { get; set; }

        /// <summary>
        /// Policy ID
        /// </summary>
        public int PolicyId { get; set; }

        /// <summary>
        /// Policy Type
        /// </summary>
        public PolicyType Type { get; set; }

        /// <summary>
        /// Language of the policy.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// URL of the portal of the policy.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Policy text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Date of acceptance if it is accepted
        /// </summary>
        public DateTime? AcceptedOn { get; set; }

        /// <summary>
        /// Date of revocation if it is revoked
        /// </summary>
        public DateTime? RevokedOn { get; set; }

        /// <summary>
        /// Flag indicating that the policy has a new version.
        /// </summary>
        public bool IsOutdated { get; set; }
    }
}
