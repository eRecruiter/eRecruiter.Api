namespace eRecruiter.Api.Responses
{
    public class JobPublicationResponse
    {
        public string Name { get; set; }
        public string Account { get; set; }
        public string Channel { get; set; }
        public JobPublicationType Type { get; set; }
        public JobPublicationPartner Partner { get; set; }

        public enum JobPublicationType
        {
            Portal,
            Channel,
            MultiPostChannel
        }

        public enum JobPublicationPartner
        {
            Persy
        }
    }
}