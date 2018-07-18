using System.Collections.Generic;
using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests.Application
{
    public class ApplicationsByJobRequests : HttpRequestMessage<IEnumerable<ApplicationJobResponse>>
    {
        #region Constructor

        public ApplicationsByJobRequests(int jobId) : base(HttpMethod.Get, $"Api/Applications/ByJob/{jobId}")
        {
        }

        #endregion
    }
}