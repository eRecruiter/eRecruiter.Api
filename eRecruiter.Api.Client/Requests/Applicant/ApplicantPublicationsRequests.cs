using System.Collections.Generic;
using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantPublicationsGetRequest : HttpRequestMessage<IEnumerable<ApplicantPublicationResponse>>
    {
        public ApplicantPublicationsGetRequest(int applicantId)
            : base(HttpMethod.Get, "Api/Applicant/Publications/" + applicantId)
        {
        }
    }
}
