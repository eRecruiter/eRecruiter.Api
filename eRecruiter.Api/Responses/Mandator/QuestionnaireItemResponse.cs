namespace eRecruiter.Api.Responses
{
    public class QuestionnaireItemResponse
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRequired { get; set; }
        public QuestionnaireItemType Type { get; set; }

        // these only contain values when the type matches
        public CustomFieldResponse CustomField { get; set; }
        public string Language { get; set; }
        public string Knowledge { get; set; }
        public string KnowledgeGroup { get; set; }

        public enum QuestionnaireItemType
        {
            SingleLanguage,
            SingleKnowledge,
            Headline,
            CustomField,
            KnowledgeGroup,
            AbroadTravelling,
            DomesticTravelling,
            BeginDate,
            Salary,
            MilitaryService,
            WillingToMove,
            SelfDescription,
            JobDescription,
            SubHeadline,
            Languages,
            Referrer,
            JobProfiles,
            Regions,
            Location,
            EmploymentType,
            Educations,
            Experiences,
            ApplicantDocument

        }
    }
}