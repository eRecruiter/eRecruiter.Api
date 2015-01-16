using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class ApplicationResponse
    {
        /// <summary>
        /// The unique identifier of the application.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The id of the associated applicant to this application.
        /// </summary>
        public int ApplicantId { get; set; }

        /// <summary>
        /// The id of the associated job.
        /// </summary>
        public int JobId { get; set; }

        /// <summary>
        /// The current status of the application.
        /// </summary>
        public string Status { get; set; }

        public string StatusForApplicant { get; set; }
        public string StatusForContact { get; set; }

        /// <summary>
        /// Specifies wether the application is visible to the applicant or not.
        /// </summary>
        public bool IsVisibleToApplicant { get; set; }

        /// <summary>
        /// Specifies wether the application is visible to the job contact or not.
        /// </summary>
        public bool IsVisibleToContact { get; set; }

        /// <summary>
        /// The referrer specifies from which source the applicant applied to the job.
        /// </summary>
        public string Referrer { get; set; }

        /// <summary>
        /// Some additional info to the <see cref="Referrer"/>.
        /// </summary>
        public string ReferrerAdditionalInfo { get; set; }

        public IEnumerable<ApplicationActivityResponse> AvailableActivities { get; set; }

        public class ApplicationActivityResponse
        {
            public string Name { get; set; }
            public string NameForApplicant { get; set; }
            public string NameForContact { get; set; }
            public bool IsVisibleToApplicant { get; set; }
            public ApplicationActivityAvailability AvailableToContact { get; set; }
        }

        public override string ToString()
        {
            if (ApplicantId > 0 && JobId > 0)
            {
                return "Applicant #" + ApplicantId + " - Job #" + JobId + " (" + Status + ")";
            }
            return base.ToString();
        }
    }
}
