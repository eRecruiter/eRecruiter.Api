using System.Collections.Generic;

namespace eRecruiter.Api.Responses.Job
{
    public class GoogleForJobsResponse
    {
        public List<string> EmploymentType { get; set; }
        public bool Telecommute { get; set; }
        public string Country { get; set; }
        public int? MinSalary { get; set; }
        public int? MaxSalary { get; set; }
        public string SalaryUnit { get; set; }
        public string Content { get; set; }
        public string Currency { get; set; }
        public List<GoogleForJobsLocationResponse> Locations { get; set; }
    }
}
