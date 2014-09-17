using System.Collections.Generic;
using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantActivitiesGetRequest : HttpRequestMessage<IEnumerable<ApplicantActivityResponse>>
    {
        public ApplicantActivitiesGetRequest(int applicantId)
            : base(HttpMethod.Get, "Api/Applicant/Activities/" + applicantId)
        {
        }
    }
}
