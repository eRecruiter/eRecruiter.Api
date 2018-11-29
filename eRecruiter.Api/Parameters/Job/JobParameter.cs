using System.Collections.Generic;

namespace eRecruiter.Api.Parameters
{
    /// <summary>
    /// Information about a new job
    /// </summary>
    public class JobParameter
    {
        public string Name{ get; set; }
        public JobStatus Status { get; set; }
        public int CompanyId{ get; set; }
        public int UserId { get; set; }
        public int ContactId { get; set; }
        public string JobProfile { get; set; }
        public bool? JobProfileAssignedOnApply { get; set; }
        public string CareerLevel { get; set; }
        public string OccupationType { get; set; }
        public double? SalaryFrom { get; set; }
        public double? SalaryTo { get; set; }
        public IList<CustomFieldParameter> CustomFields { get; set; }  
        public IList<JobTextParameter> JobTexts { get; set; }
       
    }
}
