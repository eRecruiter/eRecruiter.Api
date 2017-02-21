using System.Collections.Generic;

namespace eRecruiter.Api.Parameters
{
    public class CustomFieldValueParameter
    {
        /// <summary>
        /// Represents the internal name (identifier) of the associated custom field.
        /// </summary>
        public string CustomField { get; set; }

        /// <summary>
        /// Stores the formatted version of either bool, string, date or number value.
        /// Depending on the CustomFieldType of the CustomField a different format of the value has to be provided.
        /// * TextMultiLine, TextSingleLine: the text as string.
        /// * CheckBox: "true" or "false" as string
        /// * DropdownList: the selected value as string
        /// * Date: The datetime as string
        /// * Html: Not supported
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// A collection of string values if the custom field type is of type CustomFieldType.CheckboxList.
        /// </summary>
        public IEnumerable<string> Values { get; set; }
    }
}
