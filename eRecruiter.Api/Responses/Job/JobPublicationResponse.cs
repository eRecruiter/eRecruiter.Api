
namespace eRecruiter.Api.Responses
{
    public class JobPublicationResponse
    {
        public string Name { get; set; }
        public JobPublicationType Type { get; set; }

        public enum JobPublicationType
        {
            Portal,
            Channel
        }
    }
}
