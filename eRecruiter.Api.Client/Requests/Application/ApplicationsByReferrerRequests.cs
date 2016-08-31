using System;
using System.Collections.Generic;
using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests.Application
{
    public class ApplicationsByReferrerRequests : HttpRequestMessage<IEnumerable<ApplicationReferrerResponse>>
    {
        #region Constructor

        public ApplicationsByReferrerRequests(string referrer, DateTime? startAt = null, DateTime? endAt = null) : 
            base(HttpMethod.Get, $"Api/Applications/ByReferrer/{Uri.EscapeDataString(referrer)}?" +
                                 $"startAt={Uri.EscapeDataString(startAt?.ToString("O") ?? string.Empty)}&" +
                                 $"endAt={Uri.EscapeDataString(endAt?.ToString("O") ?? string.Empty)}")
        {
        }

        #endregion
    }
}