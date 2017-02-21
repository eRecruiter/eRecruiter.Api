using System;

namespace eRecruiter.Api.Responses
{
    public class CustomFieldValueResponse
    {
        /// <summary>
        /// The associated custom field where the value belongs to.
        /// </summary>
        public CustomFieldResponse CustomField { get; set; }

        /// <summary>
        /// Contains a formatted version of either bool, string, date or number value.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Contains a boolean value true or false if type is CustomFieldType.CheckBox.
        /// </summary>
        public bool? BoolValue { get; set; }

        /// <summary>
        /// Contains a datetime value type is CustomFieldType.Date.
        /// </summary>
        public DateTime? DateValue { get; set; }

        /// <summary>
        /// Contains a string if type is either CustomFieldType.TextMultiLine, CustomFieldType.TextSingleLine, CustomFieldType.DropdownList or CustomFieldType.Html.
        /// If type is CustomFieldType.CheckboxList the property contains all values separated by the "|" character.
        /// </summary>
        public string StringValue { get; set; }

        /// <summary>
        /// Contains a number value if a value of any type (usually CustomFieldType.DropdownList) can be parsed to a number.
        /// </summary>
        public decimal? NumberValue { get; set; }
    }
}
