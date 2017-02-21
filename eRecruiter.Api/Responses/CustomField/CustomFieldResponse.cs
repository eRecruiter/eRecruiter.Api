using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class CustomFieldResponse
    {
        /// <summary>
        /// Represents the internal name of the custom field.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Represents the "public" name of the custom field.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The name of the group the custom field is associated to.
        /// </summary>
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
            TextSingleLine,
            Html
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
