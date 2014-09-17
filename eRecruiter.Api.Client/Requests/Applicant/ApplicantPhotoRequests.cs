using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantPhotoGetRequest : HttpRequestMessage<ApplicantDocumentResponse>
    {
        public ApplicantPhotoGetRequest(int applicantId, bool includeContent = true)
            : base(HttpMethod.Get, "Api/Applicant/Photo/" + applicantId + "?includeContent=" + includeContent)
        {
        }
    }

    public class ApplicantPhotoPutRequest : PutJsonHttpRequestMessage<ApplicantDocumentResponse>
    {
        public ApplicantPhotoPutRequest(int applicantId, ApplicantDocumentParameter document)
            : base("Api/Applicant/Photo/" + applicantId, document)
        {
        }
    }

    public class ApplicantPhotoPostRequest : PostJsonHttpRequestMessage<ApplicantDocumentResponse>
    {
        public ApplicantPhotoPostRequest(int applicantId, ApplicantDocumentParameter document)
            : base("Api/Applicant/Photo/" + applicantId, document)
        {
        }
    }

    public class ApplicantPhotoDeleteRequest : HttpRequestMessage<ApplicantDocumentResponse>
    {
        public ApplicantPhotoDeleteRequest(int applicantId)
            : base(HttpMethod.Delete, "Api/Applicant/Photo/" + applicantId)
        {
        }
    }
}
