using System.Collections.Generic;
using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantExperiencesGetRequest : HttpRequestMessage<IEnumerable<ApplicantExperienceResponse>>
    {
        public ApplicantExperiencesGetRequest(int applicantId)
            : base(HttpMethod.Get, "Api/Applicant/Experiences/" + applicantId)
        {
        }
    }
}
