using System.Collections.Generic;
using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantCertificatesGetRequest : HttpRequestMessage<IEnumerable<ApplicantCertificateResponse>>
    {
        public ApplicantCertificatesGetRequest(int applicantId)
            : base(HttpMethod.Get, "Api/Applicant/Certificates/" + applicantId)
        {
        }
    }
}
