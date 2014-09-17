using System;
using System.Net.Http;
using System.Net.Http.Formatting;

namespace eRecruiter.Api.Client.Requests
{
    public class PostJsonHttpRequestMessage<T> : HttpRequestMessage<T> where T : class
    {
        public PostJsonHttpRequestMessage(string url, object param)
            : base(HttpMethod.Post, url)
        {
            if (param == null)
                throw new ArgumentNullException("param");
            Content = new ObjectContent(param.GetType(), param, new JsonMediaTypeFormatter());
        }
    }
}
