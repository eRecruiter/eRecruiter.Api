using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class ReferrerResponse
    {
        public string Name { get; set; }
        public IEnumerable<string> CultureFilter { get; set; }
        public string Group { get; set; }
        public bool AllowsAdditionalInfo { get; set; }
        public bool IsInternalOnly { get; set; }
    }
}