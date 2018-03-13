using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRecruiter.Api.Parameters
{
    public class ApplicantPolicyParameter
    {
        /// <summary>
        /// Date of acceptance
        /// </summary>
        public DateTime? AcceptedOn { get; set; }

        /// <summary>
        /// Date of revocation
        /// </summary>
        public DateTime? RevokedOn { get; set; }
    }
}
