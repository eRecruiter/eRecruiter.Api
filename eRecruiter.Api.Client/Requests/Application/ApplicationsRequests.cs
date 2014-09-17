using eRecruiter.Api.Responses;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicationsRequest : HttpRequestMessage<IEnumerable<ApplicationResponse>>
    {
        public ApplicationsRequest(int applicantId)
            : base(HttpMethod.Get, "Api/Applications/" + applicantId + "?culture=" + CultureInfo.CurrentUICulture)
        {
        }
    }
}
