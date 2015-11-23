using System;
using System.Collections.Generic;
using System.Reflection;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Parameters
{
    public class ApplicantParameter
    {
        public enum MilitaryServiceType
        {
            NotYetDone,
            Done,
            Reliefed,
            Alternative
        }

        public enum SalaryPeriodType
        {
            Monthly,
            Yearly
        }

        /// <summary>
        /// Creates a new instance of an <see cref="ApplicantParameter"/> class and initializes the <see cref="DateOfCreation"/> property with <value>DateTime.Now</value>.
        /// </summary>
        public ApplicantParameter()
        {
            DateOfCreation = DateTime.Now; // default value for creation date
        }

        public ApplicantParameter(ApplicantResponse applicantResponse)
        {
            // just copy the value of each property
            foreach (
                var property in typeof (ApplicantParameter).GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
                property.SetValue(this,
                    typeof (ApplicantResponse).GetProperty(property.Name).GetValue(applicantResponse));
            }
        }
        
        /// <summary>
        /// The date when the applicant was created in the database.
        /// </summary>
        public DateTime DateOfCreation { get; set; }

        /// <summary>
        /// Global identifier for same appliant in different mandators.
        /// </summary>
        public int GlobalId { get; set; }

        /// <summary>
        /// Optional identifiener for third party applications.
        /// </summary>
        public int? ExternalId { get; set; }

        /// <summary>
        /// The first name of an applicant.
        /// </summary>
        /// <remarks>Required.</remarks>
        public string FirstName { get; set; }

        /// <summary>
        /// The surname of an applicant.
        /// </summary>
        /// <remarks>Required.</remarks>
        public string LastName { get; set; }

        /// <summary>
        /// The applicant's email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The applicant's gender.
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// The academic title, which usually is written before an applicant's name.
        /// </summary>
        public string TitleBeforeName { get; set; }

        /// <summary>
        /// The academic degree, which usually is written after an applicant's name.
        /// </summary>
        public string TitleAfterName { get; set; }

        /// <summary>
        /// The date of birth.
        /// </summary>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The street of an applicant's address.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// The city of an applicant's address.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The ZIP (Zone Improvement Plan) code of an applicant's address.
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// The country of an applicant's address.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// The citizenship of an applicant.
        /// </summary>
        public string Citizenship { get; set; }

        /// <summary>
        /// The telephone number of an applicant.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// The mobile phone number of an applicant.
        /// </summary>
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

        public string ImportantInfo { get; set; }

        public string SelfDescription { get; set; }
        public string JobDescription { get; set; }

        /// <summary>
        /// Is used for determining the spoken language, taken from the browser, Emails are generated in that language
        /// </summary>
        public string Culture { get; set; }

        /// <summary>
        /// Gets or sets the maximum distance to a job location desired by the applicant.
        /// </summary>
        public float? MaximumDistanceToJobLocation { get; set; }
    }
}
