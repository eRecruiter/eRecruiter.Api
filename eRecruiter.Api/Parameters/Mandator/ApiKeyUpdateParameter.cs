using eRecruiter.Api.Responses;
using System.Collections.Generic;

namespace eRecruiter.Api.Parameters
{
    public class ApiKeyUpdateParameter
    {
        public string Name { get; set; }
        public bool IsEnabled { get; set; }
        public IEnumerable<ApiKeyAccessLevel> AccessLevels { get; set; }
    }
}
