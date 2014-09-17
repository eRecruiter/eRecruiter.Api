using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantCvGetRequest : HttpRequestMessage<ApplicantDocumentResponse>
    {
        public ApplicantCvGetRequest(int applicantId, bool includeContent = true)
            : base(HttpMethod.Get, "Api/Applicant/Cv/" + applicantId + "?includeContent=" + includeContent)
        {
        }
    }

    public class ApplicantCvPutRequest : PutJsonHttpRequestMessage<ApplicantDocumentResponse>
    {
        public ApplicantCvPutRequest(int applicantId, ApplicantDocumentParameter document)
            : base("Api/Applicant/Cv/" + applicantId, document)
        {
        }
    }

    public class ApplicantCvPostRequest : PostJsonHttpRequestMessage<ApplicantDocumentResponse>
    {
        public ApplicantCvPostRequest(int applicantId, ApplicantDocumentParameter document)
            : base("Api/Applicant/Cv/" + applicantId, document)
        {
        }
    }

    public class ApplicantCvDeleteRequest : HttpRequestMessage<ApplicantDocumentResponse>
    {
        public ApplicantCvDeleteRequest(int applicantId)
            : base(HttpMethod.Delete, "Api/Applicant/Cv/" + applicantId)
        {
        }
    }
}
