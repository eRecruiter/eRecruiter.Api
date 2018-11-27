using System.Net;

namespace eRecruiter.Api.Responses
{
    public class JobCreationResponse
    {
        public int Id { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public string Message { get; set; }
    }
}
