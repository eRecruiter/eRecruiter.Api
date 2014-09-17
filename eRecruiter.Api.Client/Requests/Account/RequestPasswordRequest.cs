using System;
using System.Net.Http;
using System.Threading;

namespace eRecruiter.Api.Client.Requests
{
    public class RequestPasswordRequest : HttpRequestMessage<string>
    {
        public RequestPasswordRequest(string email, Uri currentUri)
            : base(HttpMethod.Post, "Api/Applicant/RequestPassword?email=" + email + "&url=" + currentUri + "&culture=" + Thread.CurrentThread.CurrentUICulture)
        {
        }
    }
}
