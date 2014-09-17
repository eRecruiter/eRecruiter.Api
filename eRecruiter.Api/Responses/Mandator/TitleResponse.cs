using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class TitleResponse
    {
        public string Name { get; set; }
        public IEnumerable<string> CultureFilter { get; set; }
        public string Group { get; set; }
    }
}