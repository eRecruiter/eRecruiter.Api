
namespace eRecruiter.Api.Responses
{
    public class PortalSettingsResponse
    {
        // please note that the properties are sorted just like in the eR admin area
        // don't break this!

        public bool ForceSsl { get; set; }
        public bool EnableSelfServiceZone { get; set; }
        public bool AllowApplicationWithoutJob { get; set; }
        public string DefaultCulture { get; set; }

        public bool SendRegistrationEmail { get; set; }
        public bool SendApplicationEmail { get; set; }

        public DisplayType AskForBirthdate { get; set; }
        public DisplayType AskForGender { get; set; }
        public string DefaultCountry { get; set; }
        public DisplayType AskForCoverLetter { get; set; }
        public bool AskForTitles { get; set; }
        public bool AskForCitizenship { get; set; }
        public bool AskForEmailConfirmation { get; set; }
        public bool AskForReferrer { get; set; }
        public bool AskForLocation { get; set; }
        public bool AskForRegion { get; set; }
        public DisplayType AskForCv { get; set; }
        public DisplayType AskForPhoto { get; set; }
        public bool AskForDocuments { get; set; }
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

        public bool DisplayLocationInJobListing { get; set; }
        public bool DisplayDateInJobListing { get; set; }
        public bool EnableRegionsFilterOnJobsList { get; set; }
        public bool EnableJobProfilesFilterOnJobsList { get; set; }
        public bool EnableFilterOnJobsList { get; set; }

        public bool AllowDuplicateEmail { get; set; }

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
