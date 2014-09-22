using eRecruiter.Api.Parameters;
using System;
using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class ApplicantResponse : ApplicantParameter
    {
        public int Id { get; set; }
        public DateTime DateOfUpdateByUser { get; set; }
        public DateTime DateOfUpdateByApplicant { get; set; }

        public bool HasCv { get; set; }
        public bool HasPhoto { get; set; }
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
