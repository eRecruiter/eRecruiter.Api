using System;
using System.Collections.Generic;
using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests.Application
{
    public class ApplicationsByReferrerRequests : HttpRequestMessage<IEnumerable<ApplicationReferrerResponse>>
    {
        #region Constructor

        public ApplicationsByReferrerRequests(string referrer) : base(HttpMethod.Get, "Api/Applications/ByReferrer/" + Uri.EscapeDataString(referrer))
        {
        }

        #endregion
    }
}