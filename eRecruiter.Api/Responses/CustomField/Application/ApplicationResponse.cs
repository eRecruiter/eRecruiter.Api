using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class ApplicationResponse
    {
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public int JobId { get; set; }
        public string Status { get; set; }
        public string StatusForApplicant { get; set; }
        public string StatusForContact { get; set; }
        public bool IsVisibleToApplicant { get; set; }
        public bool IsVisibleToContact { get; set; }
        public string Referrer { get; set; }
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
                return "Applicant #" + ApplicantId + " - Job #" + JobId + " (" + Status + ")";
            return base.ToString();
        }
    }
}
