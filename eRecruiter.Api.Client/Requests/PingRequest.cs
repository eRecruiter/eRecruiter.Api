using System.Net.Http;
using System.Net.Http.Formatting;

namespace eRecruiter.Api.Client.Requests
{
    public class PingRequest : HttpRequestMessage<string>
    {
        public PingRequest()
            : base(HttpMethod.Get, "Api/Ping")
        {
        }

        public PingRequest(string message)
            : base(HttpMethod.Post, "Api/Ping")
        {
            Content = new ObjectContent(message.GetType(), message, new JsonMediaTypeFormatter());
        }
    }
}
