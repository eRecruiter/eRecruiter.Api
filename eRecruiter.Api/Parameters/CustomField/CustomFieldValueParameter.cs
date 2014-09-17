using System.Collections.Generic;

namespace eRecruiter.Api.Parameters
{
    public class CustomFieldValueParameter
    {
        public string CustomField { get; set; }
        public string Value { get; set; }
        public IEnumerable<string> Values { get; set; }
    }
}
