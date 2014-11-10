using System;
using eRecruiter.Api.Responses;
using System.Collections.Generic;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class MandatorsRequest : HttpRequestMessage<IEnumerable<MandatorResponse>>
    {
        public MandatorsRequest(Uri currentUri)
            : base(HttpMethod.Get, "Api/Mandators/?uri=" + currentUri)
        {
        }

        public MandatorsRequest()
            : base(HttpMethod.Get, "Api/Mandators/")
        {
        }
    }
}
