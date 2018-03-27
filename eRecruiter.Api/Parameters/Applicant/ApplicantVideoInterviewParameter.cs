using System;

namespace eRecruiter.Api.Parameters
{
    public class ApplicantVideoInterviewParameter
    {
        /// <summary>
        /// Id of the erecruiter job
        /// </summary>
        public int JobId { get; set; }
        /// <summary>
        /// Id of the erecruiter application
        /// </summary>
        public int ApplicationId { get; set; }
        /// <summary>
        /// Id of the video recruiter provider
        /// </summary>
        public VideoRecruitingProvider Provider { get; set; }
        /// <summary>
        /// Template external id from the video recruiter provider
        /// </summary>
        public int? TemplateId { get; set; }
        /// <summary>
        /// Interview external id from the video recruiter provider
        /// </summary>
        public int? InterviewId { get; set; }
        /// <summary>
        /// Date of interview
        /// </summary>
        public DateTime? InterviewDate { get; set; }
    }
}