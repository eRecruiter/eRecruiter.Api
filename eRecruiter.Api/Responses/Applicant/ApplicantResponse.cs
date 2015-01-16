using eRecruiter.Api.Parameters;
using System;
using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class ApplicantResponse : ApplicantParameter
    {        
        /// <summary>
        /// The unique identifier of an applicant.
        /// </summary>
        public int Id { get; set; }

        public DateTime DateOfUpdateByUser { get; set; }
        public DateTime DateOfUpdateByApplicant { get; set; }

        /// <summary>
        /// Specifies wether the applicant has a curriculum vitae or not.
        /// </summary>
        public bool HasCv { get; set; }

        /// <summary>
        /// Specifies wether the applicant has a picture or not.
        /// </summary>
        public bool HasPhoto { get; set; }

        /// <summary>
        /// Specifies if there are any applications on a job, which are visible to the applicant.
        /// </summary>
        public bool HasApplicationsVisibleToApplicant { get; set; }

        public int DocumentsCount { get; set; }
        public int ActivitiesCount { get; set; }
        public int ExperiencesCount { get; set; }
        public int EducationsCount { get; set; }
        public int CertificatesCount { get; set; }
        public int LanguagesCount { get; set; }
        public int PublicationsCount { get; set; }

        public IEnumerable<ApplicantThirdPartyProfileResponse> ThirdPartyProfiles { get; set; }
    }
}
