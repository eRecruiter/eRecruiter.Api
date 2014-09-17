using System;

namespace eRecruiter.Api.Responses
{
    public class CustomFieldValueResponse
    {
        public CustomFieldResponse CustomField { get; set; }
        public string Value { get; set; } // contains a formatted version of either bool, string, date or number value

        public bool? BoolValue { get; set; }
        public DateTime? DateValue { get; set; }
        public string StringValue { get; set; }
        public decimal? NumberValue { get; set; }
    }
}
