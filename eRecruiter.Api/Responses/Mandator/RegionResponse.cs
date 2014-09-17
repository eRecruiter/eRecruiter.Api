using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class RegionResponse
    {
        public string Name { get; set; }
        public IEnumerable<RegionResponse> Regions { get; set; }
    }
}