using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class CustomFieldResponse
    {
        /// <summary>
        /// The identifier (as text) of the associated custom field. Is also known as "internal name" in the eRecruiter.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Represents the name of the custom field. Is also known as the "public name" in the eRecruiter.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The name of the group the custom field is associated to.
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// The custom field type which controls the renderer.
        /// </summary>
        public CustomFieldType Type { get; set; }

        /// <summary>
        /// The target/context the custom field is used for/in.
        /// </summary>
        public CustomFieldTarget Target { get; set; }

        /// <summary>
        /// A flag that indicates that the field is public for the job feed.
        /// </summary>
        public bool IsPublic { get; set; }

        /// <summary>
        /// The values that are possible for DropdownList and CheckboxList.
        /// </summary>
        public IEnumerable<string> PossibleValues { get; set; }

        /// <summary>
        /// The default value for the custom field.
        /// </summary>
        public string DefaultValue { get; set; }

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
