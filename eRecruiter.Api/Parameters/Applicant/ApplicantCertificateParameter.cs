namespace eRecruiter.Api.Parameters
{
    public class ApplicantCertificateParameter
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public FlexDate Start { get; set; }
        public FlexDate End { get; set; }
    }
}
