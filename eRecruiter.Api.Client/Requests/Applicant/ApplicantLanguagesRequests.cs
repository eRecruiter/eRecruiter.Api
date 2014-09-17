using System.Collections.Generic;
using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantLanguagesGetRequest : HttpRequestMessage<IEnumerable<ApplicantLanguageResponse>>
    {
        public ApplicantLanguagesGetRequest(int applicantId)
            : base(HttpMethod.Get, "Api/Applicant/Languages/" + applicantId)
        {
        }
    }


}
