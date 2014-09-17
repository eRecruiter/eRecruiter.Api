using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantCertificateGetRequest : HttpRequestMessage<ApplicantCertificateResponse>
    {
        public ApplicantCertificateGetRequest(int certificateId)
            : base(HttpMethod.Get, "Api/Applicant/Certificate/" + certificateId)
        {
        }
    }

    public class ApplicantCertificatePutRequest : PutJsonHttpRequestMessage<ApplicantCertificateResponse>
    {
        public ApplicantCertificatePutRequest(int applicantId, ApplicantCertificateParameter certificate)
            : base("Api/Applicant/Certificate/" + applicantId, certificate)
        {
        }
    }

    public class ApplicantCertificatePostRequest : PostJsonHttpRequestMessage<ApplicantCertificateResponse>
    {
        public ApplicantCertificatePostRequest(int certificateId, ApplicantCertificateParameter certificate)
            : base("Api/Applicant/Certificate/" + certificateId, certificate)
        {
        }
    }

    public class ApplicantCertificateDeleteRequest : HttpRequestMessage<ApplicantCertificateResponse>
    {
        public ApplicantCertificateDeleteRequest(int certificateId)
            : base(HttpMethod.Delete, "Api/Applicant/Certificate/" + certificateId)
        {
        }
    }
}
