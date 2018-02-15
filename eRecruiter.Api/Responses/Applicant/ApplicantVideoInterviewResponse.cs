using System;

namespace eRecruiter.Api.Responses
{
    public class ApplicantVideoInterviewResponse
    {
        /// <summary>
        /// Applicant ID
        /// </summary>
        public int ApplicantId { get; set; }

        /// <summary>
        /// Job ID (if available)
        /// </summary>
        public int? JobId { get; set; }

        /// <summary>
        /// Application ID (if available)
        /// </summary>
        public int? ApplicationId { get; set; }

        /// <summary>
        /// Video Recruiting Provider
        /// </summary>
        public VideoRecruitingProvider Provider { get; set; }

        /// <summary>
        /// URL to playback the video, valid for 3 playbacks.
        /// </summary>
        public Uri PlaybackUrl { get; set; }
    }
}
