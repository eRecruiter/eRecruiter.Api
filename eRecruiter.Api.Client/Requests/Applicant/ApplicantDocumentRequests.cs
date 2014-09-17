using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantDocumentGetRequest : HttpRequestMessage<ApplicantDocumentResponse>
    {
        public ApplicantDocumentGetRequest(int documentId, bool includeContent = true)
            : base(HttpMethod.Get, "Api/Applicant/Document/" + documentId + "?includeContent=" + includeContent)
        {
        }
    }

    public class ApplicantDocumentPutRequest : PutJsonHttpRequestMessage<ApplicantDocumentResponse>
    {
        public ApplicantDocumentPutRequest(int applicantId, ApplicantDocumentParameter document)
            : base("Api/Applicant/Document/" + applicantId, document)
        {
        }
    }

    public class ApplicantDocumentPostRequest : PostJsonHttpRequestMessage<ApplicantDocumentResponse>
    {
        public ApplicantDocumentPostRequest(int documentId, ApplicantDocumentParameter document)
            : base("Api/Applicant/Document/" + documentId, document)
        {
        }
    }

    public class ApplicantDocumentDeleteRequest : HttpRequestMessage<ApplicantDocumentResponse>
    {
        public ApplicantDocumentDeleteRequest(int documentId)
            : base(HttpMethod.Delete, "Api/Applicant/Document/" + documentId)
        {
        }
    }
}
