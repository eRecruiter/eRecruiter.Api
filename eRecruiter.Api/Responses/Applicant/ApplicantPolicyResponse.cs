using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRecruiter.Api.Responses.Policies;

namespace eRecruiter.Api.Responses
{
    public class ApplicantPolicyResponse
    {
        /// <summary>
        /// Applicant ID
        /// </summary>
        public int ApplicantId { get; set; }

        /// <summary>
        /// Policy ID
        /// </summary>
        public int? PolicyId { get; set; }

        /// <summary>
        /// Policy text
        /// </summary>
        public string Text  { get; set; }

        /// <summary>
        /// Date of acceptance if it is accepted
        /// </summary>
        public DateTime? AcceptedOn { get; set; }

        /// <summary>
        /// Date of revocation if it is revoked
        /// </summary>
        public DateTime? RevokedOn { get; set; }

        /// <summary>
        /// Policy Type
        /// </summary>
        public PolicyType Type { get; set; }
    }
}
