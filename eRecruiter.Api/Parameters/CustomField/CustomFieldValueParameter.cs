using System.Collections.Generic;

namespace eRecruiter.Api.Parameters
{
    /// <summary>
    /// Represents the value of a custom field.
    /// </summary>
    public class CustomFieldValueParameter
    {
        /// <summary>
        /// The identifier (as text) of the associated custom field. Is also known as "internal name" in the eRecruiter.
        /// </summary>
        public string CustomField { get; set; }

        /// <summary>
        /// Stores the formatted version of either bool, string, date or number value.
        /// Depending on the CustomFieldType of the CustomField a different format of the value has to be provided.
        /// * TextMultiLine, TextSingleLine: the text as string.
        /// * CheckBox: "true" or "false" as string
        /// * DropdownList: the selected value as string
        /// * Date: A string representation of the datetime as short date pattern (format specifier "d").
        /// * Html: Not supported
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// A collection of string values if the custom field type is of type CustomFieldType.CheckboxList.
        /// </summary>
        public IEnumerable<string> Values { get; set; }
    }
}
