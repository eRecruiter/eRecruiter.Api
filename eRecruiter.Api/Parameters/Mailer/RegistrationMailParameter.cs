namespace eRecruiter.Api.Parameters
{
    public class RegistrationMailParameter
    {
        /// <summary>
        /// ID of the applicant the e-mail should be sent to.
        /// </summary>
        public int ApplicantId { get; set; }

        /// <summary>
        /// The current applicant portal URL (if applicable). This is used to match for applicant portal settings. 
        /// If empty or no match can be found, the default applicant portal settings will be used.
        /// </summary>
        public string Url { get; set; }
    }
}
