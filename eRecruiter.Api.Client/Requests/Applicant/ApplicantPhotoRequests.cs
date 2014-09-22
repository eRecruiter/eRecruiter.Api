using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantPhotoGetRequest : HttpRequestMessage<ApplicantPhotoResponse>
    {
        public ApplicantPhotoGetRequest(int applicantId, bool includeContent = true)
            : base(HttpMethod.Get, "Api/Applicant/Photo/" + applicantId + "?includeContent=" + includeContent)
        {
        }
    }

    public class ApplicantPhotoPutRequest : PutJsonHttpRequestMessage<ApplicantPhotoResponse>
    {
        public ApplicantPhotoPutRequest(int applicantId, ApplicantPhotoParameter document)
            : base("Api/Applicant/Photo/" + applicantId, document)
        {
        }
    }

    public class ApplicantPhotoPostRequest : PostJsonHttpRequestMessage<ApplicantPhotoResponse>
    {
        public ApplicantPhotoPostRequest(int applicantId, ApplicantPhotoParameter document)
            : base("Api/Applicant/Photo/" + applicantId, document)
        {
        }
    }

    public class ApplicantPhotoDeleteRequest : HttpRequestMessage<ApplicantPhotoResponse>
    {
        public ApplicantPhotoDeleteRequest(int applicantId)
            : base(HttpMethod.Delete, "Api/Applicant/Photo/" + applicantId)
        {
        }
    }
}
