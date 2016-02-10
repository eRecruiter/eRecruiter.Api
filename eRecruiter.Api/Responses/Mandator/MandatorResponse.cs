using System;
using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class MandatorResponse
    {
        /// <summary>
        /// The unique identifier of the mandator.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the mandator.
        /// </summary>
        public string Name { get; set; }

        public PortalSettingsResponse PortalSettings { get; set; }

        /// <summary>
        /// All available translations for values, identified by a key.
        /// </summary>
        public IEnumerable<TranslationResponse> Translations { get; set; }

        /// <summary>
        /// A list containing all the job profile names.
        /// </summary>
        public IEnumerable<string> JobProfiles { get; set; }

        /// <summary>
        /// All available job profiles containing group and culture information.
        /// </summary>
        public IEnumerable<JobProfileResponse> GroupedJobProfiles { get; set; }

        public IEnumerable<RegionResponse> Regions { get; set; }
        public IEnumerable<string> Urls { get; set; }
        public IEnumerable<string> ApplicantDocumentTypes { get; set; }
        public IEnumerable<TitleResponse> TitlesBeforeName { get; set; }
        public IEnumerable<TitleResponse> TitlesAfterName { get; set; }
        public IEnumerable<string> Countries { get; set; }
        public IEnumerable<string> PublicationTypes { get; set; }
        public IEnumerable<string> Languages { get; set; }
        public IEnumerable<string> LanguageLevels { get; set; }
        public IEnumerable<string> CertificateTypes { get; set; }
        public IEnumerable<string> EducationTypes { get; set; }
        public IEnumerable<string> CareerLevels { get; set; }
        public IEnumerable<string> SalaryCurrencies { get; set; }
        public IEnumerable<string> DomesticTravellingTypes { get; set; }
        public IEnumerable<string> AbroadTravellingTypes { get; set; }
        public IEnumerable<string> PhoneTimes { get; set; }
        public IEnumerable<string> Knowledges { get; set; }
        public IEnumerable<string> KnowledgeLevels { get; set; }
        public IEnumerable<ReferrerResponse> Referrers { get; set; }
        public IEnumerable<JobPublicationResponse> JobPublicationTypes { get; set; }
        public IEnumerable<CustomFieldResponse> CustomFields { get; set; }
        public IEnumerable<string> ClassificationTypes { get; set; }
        
        /// <summary>
        /// All available values for occupation types for jobs.
        /// </summary>
        public IEnumerable<string> OccupationTypes { get; set; } 
    }
}
