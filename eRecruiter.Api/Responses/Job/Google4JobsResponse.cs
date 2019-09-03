using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRecruiter.Api.Responses.Job
{
    public class Google4JobsResponse
    {
        public string EmploymentType { get; set; }
        public bool Telecommute { get; set; }
        public string Country { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
        public string SalaryUnit { get; set; }
        public string Content { get; set; }
        public Google4JobsLocationResponse Location { get; set; }
    }
}
