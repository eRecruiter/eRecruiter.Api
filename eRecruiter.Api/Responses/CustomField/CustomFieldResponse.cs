using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class CustomFieldResponse
    {
        public string Name { get; set; } // represents the internal name

        public string Title { get; set; } // represents the "public" name
        public string GroupName { get; set; }

        public CustomFieldType Type { get; set; }
        public CustomFieldTarget Target { get; set; }

        public bool IsPublic { get; set; }

        public IEnumerable<string> PossibleValues { get; set; }

        public enum CustomFieldType
        {
            TextMultiLine,
            CheckBox,
            DropdownList,
            CheckboxList,
            Date,
            TextSingleLine
        }

        public enum CustomFieldTarget
        {
            Applicant,
            Company,
            Job,
            JobApplicant,
            JobCompany,
            ApplicantCompany,
            JobApplicantCompany
        }
    }
}