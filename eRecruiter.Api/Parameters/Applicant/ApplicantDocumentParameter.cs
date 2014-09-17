namespace eRecruiter.Api.Parameters
{
    public class ApplicantDocumentParameter
    {
        public string Name { get; set; }
        public string FileExtension { get; set; }
        public string Type { get; set; }
        public byte[] Content { get; set; }
    }
}
