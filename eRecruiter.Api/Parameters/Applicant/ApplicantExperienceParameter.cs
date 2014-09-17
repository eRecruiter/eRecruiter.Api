
namespace eRecruiter.Api.Parameters
{
    public class ApplicantExperienceParameter
    {
        public string Name { get; set; }
        public string CareerLevel { get; set; }
        public string Position { get; set; }       
        public FlexDate Start { get; set; }
        public FlexDate End { get; set; }
        public string Tasks { get; set; }
        public string ReasonForQuitting { get; set; }

        public ApplicantExperienceReference Reference { get; set; }

        public class ApplicantExperienceReference
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public Gender Gender { get; set; }
            public string Position { get; set; }
            public string MobilePhone { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public string Notes { get; set; }
            public string Feedback { get; set; }
        }
    }
}
