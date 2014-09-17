namespace eRecruiter.Api.Parameters
{
    public class ApplicantEducationParameter
    {
        public string Type { get; set; }
        public string Location { get; set; }
        public string Specialization { get; set; }       
        public FlexDate Start { get; set; }
        public FlexDate End { get; set; }
        public bool? IsFinished { get; set; }
    }
}
