using System;

namespace eRecruiter.Api.Responses
{
    public class JobPublicationResponse
    {
        public string Name { get; set; }
        public string Partner { get; set; }
        public string Account { get; set; }
        public int? Channel { get; set; }
        public DateTime PublicationDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public JobPublicationType Type { get; set; }

        public enum JobPublicationType
        {
            Portal,
            Channel,
            MultiPostChannel
        }
    }
}