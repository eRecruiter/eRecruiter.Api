using System;
using System.Net.Http;
using System.Net.Http.Formatting;

namespace eRecruiter.Api.Client.Requests
{
    public class PutJsonHttpRequestMessage<T> : HttpRequestMessage<T> where T : class
    {
        public PutJsonHttpRequestMessage(string url, object param)
            : base(HttpMethod.Put, url)
        {
            if (param == null)
            {
                throw new ArgumentNullException("param");
            }
            Content = new ObjectContent(param.GetType(), param, new JsonMediaTypeFormatter());
        }
    }
}
