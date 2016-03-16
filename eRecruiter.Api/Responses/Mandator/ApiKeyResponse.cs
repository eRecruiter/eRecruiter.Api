using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class ApiKeyResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public int MandatorId { get; set; }
        public bool IsEnabled { get; set; }
        public IEnumerable<ApiKeyAccessLevel> AccessLevels { get; set; }
    }

    public enum ApiKeyAccessLevel
    {
        Jobs,
        Applicants,
        Users,
        Companies
    }
}
