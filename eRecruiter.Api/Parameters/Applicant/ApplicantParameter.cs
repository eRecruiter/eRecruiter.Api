using eRecruiter.Api.Responses;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace eRecruiter.Api.Parameters
{
    public class ApplicantParameter
    {
        public ApplicantParameter()
        {
        }

        public ApplicantParameter(ApplicantResponse applicantResponse)
        {
            // just copy the value of each property
            foreach (var property in typeof (ApplicantParameter).GetProperties(BindingFlags.Instance | BindingFlags.Public))
                property.SetValue(this, typeof (ApplicantResponse).GetProperty(property.Name).GetValue(applicantResponse));
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }

        public string TitleBeforeName { get; set; }
        public string TitleAfterName { get; set; }

        public DateTime? BirthDate { get; set; }

        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string Citizenship { get; set; }

        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string Url { get; set; }

        public bool IsActive { get; set; }
        public bool EnableNewsletter { get; set; }
        public bool EnableMatchingJobsAutoMail { get; set; }

        public IEnumerable<string> Tags { get; set; }
        public IEnumerable<string> JobProfiles { get; set; }
        public IEnumerable<string> Regions { get; set; }

        public string CareerLevel { get; set; }
        public string Location { get; set; }
        public int? Salary { get; set; }
        public string SalaryNotes { get; set; }
        public string SalaryCurrency { get; set; }
        public SalaryPeriodType? SalaryPeriod { get; set; }
        public string DomesticTravelling { get; set; }
        public string AbroadTravelling { get; set; }
        public FlexDate EarliestPossibleBeginDate { get; set; }
        public string PhoneTime { get; set; }

        public MilitaryServiceType? MilitaryService { get; set; }
        public FlexDate MilitaryServiceStart { get; set; }
        public FlexDate MilitaryServiceEnd { get; set; }
        public string MilitaryServiceReliefReason { get; set; }

        public bool? IsWillingToMove { get; set; }
        public bool? IsInterestedInInternship { get; set; }
        public bool? IsInterestedInFulltime { get; set; }
        public bool? IsInterestedInFreelancer { get; set; }
        public bool? IsInterestedInPartTime { get; set; }
        public int? OvertimeHours { get; set; }
        public int? PartTimeHours { get; set; }

        public string Referrer { get; set; }
        public string ReferrerAdditionalInfo { get; set; }

        public string Classification { get; set; }
        public string ClassificationReason { get; set; }

        public string SelfDescription { get; set; }
        public string JobDescription { get; set; }

        public string Culture { get; set; }

        public enum SalaryPeriodType
        {
            Monthly,
            Yearly
        }

        public enum MilitaryServiceType
        {
            NotYetDone,
            Done,
            Reliefed,
            Alternative
        }
    }
}
