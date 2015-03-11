﻿
using eRecruiter.Api.Parameters;

namespace eRecruiter.Api.Responses
{
    public class PortalSettingsResponse
    {
        // please note that the properties are sorted just like in the eR admin area
        // don't break this!

        #region General settings

        public bool ForceSsl { get; set; }
        public bool EnableSelfServiceZone { get; set; }
        public bool AllowApplicationWithoutJob { get; set; }
        public string DefaultCulture { get; set; }

        #endregion General settings

        public bool SendRegistrationEmail { get; set; }
        public bool SendApplicationEmail { get; set; }

        #region Applicanta data

        /// <summary>
        /// Specifies if or how the input field of an applicants's <see cref="ApplicantParameter.Gender"/> should be displayed in the Self-Service-Zone.
        /// </summary>
        public DisplayType AskForGender { get; set; }

        /// <summary>
        /// Specifies if or how the input fields of an applicants's <see cref="ApplicantParameter.TitleAfterName"/> or <see cref="ApplicantParameter.TitleAfterName"/> should be displayed in the Self-Service-Zone.
        /// </summary>
        public DisplayType AskForTitles { get; set; }

        /// <summary>
        /// Specifies if or how the input field of an applicants's <see cref="ApplicantParameter.Email"/> should be displayed in the Self-Service-Zone.
        /// </summary>
        public DisplayType AskForEmail { get; set; }

        /// <summary>
        /// Specifies if or how the input field of an applicants's <see cref="ApplicantParameter.Phone"/> should be displayed in the Self-Service-Zone.
        /// </summary>
        public DisplayType AskForPhoneNumber { get; set; }

        /// <summary>
        /// Specifies if or how the input field of an applicants's <see cref="ApplicantParameter.BirthDate"/> should be displayed in the Self-Service-Zone.
        /// </summary>
        public DisplayType AskForBirthdate { get; set; }

        /// <summary>
        /// Specifies if or how the input fields of an applicants's <see cref="ApplicantParameter.Street"/>, <see cref="ApplicantParameter.ZipCode"/> and <see cref="ApplicantParameter.City"/> should be displayed in the Self-Service-Zone.
        /// </summary>
        public DisplayType AskForAddress { get; set; }

        /// <summary>
        /// Specifies if or how the input field of an applicants's <see cref="ApplicantParameter.Country"/> should be displayed in the Self-Service-Zone.
        /// </summary>
        public DisplayType AskForCountry { get; set; }

        /// <summary>
        /// Specifies the default value of an applicant's <see cref="ApplicantParameter.Country"/> property.
        /// </summary>
        public string DefaultCountry { get; set; }

        /// <summary>
        /// Specifies if or how the input field of an applicants's <see cref="ApplicantParameter.Citizenship"/> should be displayed in the Self-Service-Zone.
        /// </summary>
        public DisplayType AskForCitizenship { get; set; }

        /// <summary>
        /// Specifies if or how the input field of a coverletter should be displayed on the register page or the job application page.
        /// </summary>
        public DisplayType AskForCoverLetter { get; set; }

        /// <summary>
        /// Specifies if or how the upload control of an applicants's CV (<see cref="ApplicantCvParameter"/>) should be displayed in the Self-Service-Zone.
        /// </summary>
        public DisplayType AskForCv { get; set; }

        /// <summary>
        /// Specifies if or how the upload control of an applicants's picture (<see cref="ApplicantPhotoParameter"/>) should be displayed in the Self-Service-Zone.
        /// </summary>
        public DisplayType AskForPhoto { get; set; }

        /// <summary>
        /// Specifies wether the upload control of an applicants's documents (<see cref="ApplicantDocumentParameter"/>) should be displayed in the Self-Service-Zone or not.
        /// </summary>
        public bool AskForDocuments { get; set; }

        public bool AskForReferrer { get; set; }
        public bool AskForLocation { get; set; }
        public bool AskForRegion { get; set; }    
        public bool AskForNewsletter { get; set; }
        public bool AskForMatchingJobsMail { get; set; }
        public bool AskForQuitReason { get; set; }
        public bool AskForReferences { get; set; }
        public bool AskForOvertime { get; set; }
        public bool AskForSelfDescription { get; set; }
        public bool AskForJobDescription { get; set; }
        public bool AskForEmploymentType { get; set; }
        public bool AskForFreelancing { get; set; }
        public bool AskForInternship { get; set; }
        public bool AskForSalary { get; set; }
        public bool AskForWillingnessToMove { get; set; }
        public bool AskForAbroadTravelling { get; set; }
        public bool AskForDomesticTravelling { get; set; }
        public bool AskForActivities { get; set; }
        public bool AskForJobRequirements { get; set; }
        public bool AskForExperience { get; set; }
        public bool AskForEducation { get; set; }
        public bool AskForCertificates { get; set; }
        public bool AskForEarliestPossibleBeginDate { get; set; }
        public bool AskForLanguages { get; set; }
        public bool AskForPublications { get; set; }
        public bool AskForTags { get; set; }
        public bool AskForCareerLevel { get; set; }
        public bool AskForJobProfiles { get; set; }

        #region Applicanta data on register page

        /// <summary>
        /// Specifies if a second input field for confirmation of an applicant's <see cref="ApplicantParameter.Email"/> should be displayed on the register page.
        /// </summary>
        public bool AskForEmailConfirmation { get; set; }

        #endregion Applicanta data on register page

        #endregion Applicanta data

        public bool DisplayLocationInJobListing { get; set; }
        public bool DisplayDateInJobListing { get; set; }
        public bool EnableRegionsFilterOnJobsList { get; set; }
        public bool EnableJobProfilesFilterOnJobsList { get; set; }
        public bool EnableFilterOnJobsList { get; set; }

        public bool AllowDuplicateEmail { get; set; }

        /// <summary>
        /// Enables the parsing of a CV if <value>true</value>.
        /// </summary>
        /// <remarks>This setting affects the Login, Register and JobAd page.</remarks>
        public bool EnableCvParsing { get; set; }

        /// <summary>
        /// This setting depends on the <see cref="EnableSelfServiceZone"/> setting.
        /// If this setting is <value>true</value>, an applicant is able to delete their profile.
        /// </summary>
        public bool EnableDeleteForApplicant { get; set; }

        public bool EnableExtendedXml { get; set; }
        public bool EnableJobTagsInXmlFeed { get; set; }
        public bool EnableFourthJobBlockInXmlFeed { get; set; }
        
        public string XingConsumerKey { get; set; }
        public string XingConsumerSecret { get; set; }
        public string LinkedinConsumerKey { get; set; }
        public string LinkedinConsumerSecret { get; set; }

        public enum DisplayType
        {
            DoNotDisplay,
            DisplayRequired,
            DisplayNotRequired
        }
    }
}
