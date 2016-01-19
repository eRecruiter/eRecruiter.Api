namespace eRecruiter.Api.Parameters
{
    public class DoubleOptInParameter
    {
        /// <summary>
        /// The applicant's e-mail address.
        /// </summary>
        public string EMail { get; set; }

        /// <summary>
        /// The applicant's firstname.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The applicant's last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The double-opt-in verification token for the applicant.
        /// </summary>
        public string DoubleOptInToken { get; set; }
        
        /// <summary>
        /// The job ID the applicant has been trying to apply to.
        /// </summary>
        public int? JobId { get; set; }

        /// <summary>
        /// The current applicant portal URL (if applicable). This is used to match for applicant portal settings. 
        /// If empty or not match can be found, the default applicant portal settings will be used.
        /// </summary>
        public string Url { get; set; }
    }
}
