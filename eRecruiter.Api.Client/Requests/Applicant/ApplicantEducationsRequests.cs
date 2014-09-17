using System.Collections.Generic;
using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantEducationsGetRequest : HttpRequestMessage<IEnumerable<ApplicantEducationResponse>>
    {
        public ApplicantEducationsGetRequest(int applicantId)
            : base(HttpMethod.Get, "Api/Applicant/Educations/" + applicantId)
        {
        }
    }
}
