namespace eRecruiter.Api.Parameters
{
    public class ApplicationMailParameter
    {
        /// <summary>
        /// ID of the application that should be used for generating the application e-mail.
        /// </summary>
        public int ApplicationId { get; set; }

        /// <summary>
        /// The current applicant portal URL (if applicable). This is used to match for applicant portal settings. 
        /// If empty or not match can be found, the default applicant portal settings will be used.
        /// </summary>
        public string Url { get; set; }
    }
}