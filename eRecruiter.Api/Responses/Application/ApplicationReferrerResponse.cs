using System;

namespace eRecruiter.Api.Responses
{
    /// <summary>
    /// Response for application queries on referrer.
    /// </summary>
    public class ApplicationReferrerResponse
    {
        /// <summary>
        /// applicant ID
        /// </summary>
        public int ApplicantId { get; set; }

        /// <summary>
        /// application ID
        /// </summary>
        public int ApplicationId { get; set; }

        /// <summary>
        /// job ID
        /// </summary>
        public int JobId { get; set; }

        /// <summary>
        /// applicant's firstname
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// applicant's lastname
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// applicant's title before the name
        /// </summary>
        public string TitleBeforeName { get; set; }

        /// <summary>
        /// applicant's title after the name
        /// </summary>
        public string TitleAfterName { get; set; }
        
        /// <summary>
        /// applicant's gender
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// referrer/creator of the application
        /// </summary>
        public string Referrer { get; set; }

        /// <summary>
        /// additional information from the referrer/creator of the application
        /// </summary>
        public string ReferrerAdditionalInformation { get; set; }

        /// <summary>
        /// current status group of the applicant
        /// </summary>
        public WorkflowStatusGroup WorkflowStatusGroup { get; set; }

        /// <summary>
        /// last workflow state change
        /// </summary>
        public DateTime WorkflowLastChange { get; set; }
    }
}
