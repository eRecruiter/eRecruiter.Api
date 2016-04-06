using System;

namespace eRecruiter.Api.Parameters
{
    public class ApplicantHistoryParameter
    {
        /// <summary>
        /// The id of an optionally related job.
        /// </summary>
        public int? JobId { get; set; }

        /// <summary>
        /// The subject of the history entry.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// The content of the history entry.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// The type of the history entry.
        /// </summary>
        public HistoryType Type { get; set; }

        /// <summary>
        /// The information (mostly the name of the applicant, user) who created this history entry.
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// The date of creation of the history entry. If none is supplied the current time will be used.
        /// </summary>
        public DateTime? CreatedOn { get; set; }
    }
}
 