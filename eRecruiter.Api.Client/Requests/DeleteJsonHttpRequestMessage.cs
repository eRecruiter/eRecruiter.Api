using System;
using System.Net.Http;
using System.Net.Http.Formatting;

namespace eRecruiter.Api.Client.Requests
{
    public class DeleteJsonHttpRequestMessage<T> : HttpRequestMessage<T> where T : class
    {
        public DeleteJsonHttpRequestMessage(string url, object param)
            : base(HttpMethod.Delete, url)
        {
            if (param == null)
                throw new ArgumentNullException("param");
            Content = new ObjectContent(param.GetType(), param, new JsonMediaTypeFormatter());
        }
    }
}
