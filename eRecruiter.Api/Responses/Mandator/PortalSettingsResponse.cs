using System.Collections.Generic;
using eRecruiter.Api.Parameters;

namespace eRecruiter.Api.Responses
{
    /// <summary>
    /// The Applicant portal settings to configure the portal for your needs.
    /// </summary>
    public class PortalSettingsResponse
    {
        // please note that the properties are sorted just like in the eR admin area
        // don't break this!

        #region General settings

        /// <summary>
        /// Force SSL for all requests and redirect HTTP-only requests to the HTTPS endpoint.
        /// </summary>
        public bool ForceSsl { get; set; }

        /// <summary>
        /// Enable the SSZ on the portal.
        /// </summary>
        public bool EnableSelfServiceZone { get; set; }

        /// <summary>
        /// Allow applications without a job.
        /// </summary>
        public bool AllowApplicationWithoutJob { get; set; }

        /// <summary>
        /// Set the default culture for the applicant portal.
        /// </summary>
        public string DefaultCulture { get; set; }

        /// <summary>
        /// Enable double-opt-in registration workflow.
        /// </summary>
        public bool EnableDoubleOptIn { get; set; }

        #endregion General settings

        #region Language Packs

        /// <summary>
        /// ISO-2 languages codes of the available language packs on the portal.
        /// </summary>
        public IEnumerable<string> LanguagePacks { get; set; }

        #endregion

        #region E-Mail Communication

        public bool SendRegistrationEmail { get; set; }
        public bool SendApplicationEmail { get; set; }

        #endregion

        #region Applicant data

        // The applicant properties shown on the registration page are ordered as they appear on that page.

        /// <summary>
        /// Specifies if or how the input field of an applicants's <see cref="ApplicantParameter.Gender"/> should be displayed in the Self-Service-Zone.
        /// </summary>
        public DisplayType AskForGender { get; set; }

        /// <summary>
        /// Specifies if or how the input field of an applicants's <see cref="ApplicantParameter.GenderIdentity"/> should be displayed in the Self-Service-Zone.
        /// </summary>
        public DisplayType AskForGenderIdentity { get; set; }

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
        /// Specifies the default (preselected) value of the input field for of an applicant's <see cref="ApplicantParameter.Country"/> property.
        /// </summary>
        public string DefaultCountry { get; set; }

        /// <summary>
        /// Specifies if or how the input field of an applicants's <see cref="ApplicantParameter.Citizenship"/> should be displayed in the Self-Service-Zone.
        /// </summary>
        public DisplayType AskForCitizenship { get; set; }

        /// <summary>
        /// Specifies the default (preselected) value of the input field for an applicant's <see cref="ApplicantParameter.Citizenship"/> property.
        /// </summary>
        public string DefaultCitizenship { get; set; }

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
        /// Specifies if or how the consent policy should be displayed on the registration page.
        /// </summary>
        public DisplayType AskForConsentPolicy { get; set; }

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

        #region Applicanta data on registration page

        /// <summary>
        /// Specifies if or how the input field of an applicants's <see cref="ApplicantParameter.Gender"/> should be displayed on the registration page.
        /// </summary>
        public DisplayType AskForGenderOnRegistration { get; set; }

        /// <summary>
        /// Specifies if or how the input field of an applicants's <see cref="ApplicantParameter.GenderIdentity"/> should be displayed on the registration page.
        /// </summary>
        public DisplayType AskForGenderIdentityOnRegistration { get; set; }

        /// <summary>
        /// Specifies if or how the input fields of an applicants's <see cref="ApplicantParameter.TitleAfterName"/> or <see cref="ApplicantParameter.TitleAfterName"/> should be displayed on the registration page.
        /// </summary>
        public DisplayType AskForTitlesOnRegistration { get; set; }

        /// <summary>
        /// Specifies if or how the input field of an applicants's <see cref="ApplicantParameter.Email"/> should be displayed on the registration page.
        /// </summary>
        public DisplayType AskForEmailOnRegistration { get; set; }

        /// <summary>
        /// Specifies if a second input field for confirmation of an applicant's <see cref="ApplicantParameter.Email"/> should be displayed on the registration page.
        /// </summary>
        public bool AskForEmailConfirmation { get; set; }

        /// <summary>
        /// Specifies if or how the input field of an applicants's <see cref="ApplicantParameter.Phone"/> should be displayed on the registration page.
        /// </summary>
        public DisplayType AskForPhoneNumberOnRegistration { get; set; }

        /// <summary>
        /// Specifies if or how the input field of an applicants's <see cref="ApplicantParameter.BirthDate"/> should be displayed on the registration page.
        /// </summary>
        public DisplayType AskForBirthdateOnRegistration { get; set; }

        /// <summary>
        /// Specifies if or how the input fields of an applicants's <see cref="ApplicantParameter.Street"/>, <see cref="ApplicantParameter.ZipCode"/> and <see cref="ApplicantParameter.City"/> should be displayed on the registration page.
        /// </summary>
        public DisplayType AskForAddressOnRegistration { get; set; }

        /// <summary>
        /// Specifies if or how the input field of an applicants's <see cref="ApplicantParameter.Country"/> should be displayed on the registration page.
        /// </summary>
        public DisplayType AskForCountryOnRegistration { get; set; }

        /// <summary>
        /// Specifies if or how the input field of an applicants's <see cref="ApplicantParameter.Citizenship"/> should be displayed on the registration page.
        /// </summary>
        public DisplayType AskForCitizenshipOnRegistration { get; set; }

        /// <summary>
        /// Specifies if or how the input field of a coverletter should be displayed on the register page or the job application page.
        /// </summary>
        public DisplayType AskForCoverLetterOnRegistration { get; set; }

        /// <summary>
        /// Specifies if or how the upload control of an applicants's CV (<see cref="ApplicantCvParameter"/>) should be displayed on the registration page.
        /// </summary>
        public DisplayType AskForCvOnRegistration { get; set; }

        /// <summary>
        /// Specifies if or how the upload control of an applicants's picture (<see cref="ApplicantPhotoParameter"/>) should be displayed on the registration page.
        /// </summary>
        public DisplayType AskForPhotoOnRegistration { get; set; }

        /// <summary>
        /// Specifies wether the upload control of an applicants's documents (<see cref="ApplicantDocumentParameter"/>) should be displayed on the registration page or not.
        /// </summary>
        public bool AskForDocumentsOnRegistration { get; set; }

        /// <summary>
        /// Specifies if or how the video pitch should be displayed on the register page or the job application page.
        /// </summary>
        public DisplayType AskForVideoPitchOnRegistration { get; set; }

        #endregion Applicanta data on registration page

        public bool AllowDuplicateEmail { get; set; }

        /// <summary>
        /// Specifies if the day should be selectable at a Flexdate picker. If <value>True</value> the day can be selected, else <value>false</value>.
        /// </summary>
        public bool EnableExtendedDateSelection { get; set; }

        #endregion Applicanta data

        #region Job Listing

        public bool DisplayLocationInJobListing { get; set; }
        public bool DisplayDateInJobListing { get; set; }
        public bool EnableRegionsFilterOnJobsList { get; set; }
        public bool EnableJobProfilesFilterOnJobsList { get; set; }
        public bool EnableFilterOnJobsList { get; set; }
        public bool EnableCompanyPicturesOnJobsList { get; set; }
        public bool EnablePaginationInJobsList { get; set; }
        public int PageSizeJobsList { get; set; }
        #endregion

        #region CV Parser

        /// <summary>
        /// Enables the parsing of a CV if <value>true</value>.
        /// </summary>
        /// <remarks>This setting affects the Login, Register and JobAd page.</remarks>
        public bool EnableCvParsing { get; set; }

        #endregion

        #region Self-Service Zone Actions

        /// <summary>
        /// This setting depends on the <see cref="EnableSelfServiceZone"/> setting.
        /// If this setting is <value>true</value>, an applicant is able to delete their profile.
        /// </summary>
        public bool EnableDeleteForApplicant { get; set; }

        #endregion

        #region XML Feed

        public bool EnableExtendedXml { get; set; }
        public bool EnableJobTagsInXmlFeed { get; set; }
        public bool EnableFourthJobBlockInXmlFeed { get; set; }
        public bool EnableCustomerInformationInXmlFeed { get; set; }

        #endregion

        #region Third Party Profiles
        public string LinkedinConsumerKey { get; set; }
        public string LinkedinConsumerSecret { get; set; }
        public string IndeedApiToken { get; set; }
        public string IndeedApiSecret { get; set; }
        public bool IndeedApplyAllowed { get; set; }
        public string MyVeetaToken { get; set; }
        public string InstappToken { get; set; }
        public string KarriereApiKey { get; set; }
        public string KarriereApiSecret { get; set; }
        public string KarriereApiUuId { get; set; }
        public bool KarriereOneClickWidget { get; set; }
        public string LoginWithXingConsumerKey { get; set; }
        public string LoginWithXingSignatureSalt { get; set; }
        public string LoginWithJobCloudKey { get; set; }

        #endregion

        #region Applicant Profile

        public bool EnableEuropeanCvDownload { get; set; }

        #endregion Applicant Profile

        #region Display Types

        public enum DisplayType
        {
            DoNotDisplay,
            DisplayRequired,
            DisplayNotRequired
        }

        #endregion

        #region Job Map

        /// <summary>
        /// Flag indicating if the job map is enabled on the job listing.
        /// </summary>
        public bool EnableJobMap { get; set; }

        /// <summary>
        /// Flag indicating if the job map is collapsed when loading the job listing.
        /// </summary>
        public bool JobMapCollapsed { get; set; }

        #endregion

        #region Accessibility

        /// <summary>
        /// Enable the sitemap at the bottom of the screen.
        /// </summary>
        public bool EnableSitemap { get; set; }

        #endregion
    }
}
