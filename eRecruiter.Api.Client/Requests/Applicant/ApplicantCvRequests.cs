using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantCvGetRequest : HttpRequestMessage<ApplicantCvResponse>
    {
        public ApplicantCvGetRequest(int applicantId, bool includeContent = true)
            : base(HttpMethod.Get, "Api/Applicant/Cv/" + applicantId + "?includeContent=" + includeContent)
        {
        }
    }

    public class ApplicantCvPutRequest : PutJsonHttpRequestMessage<ApplicantCvResponse>
    {
        public ApplicantCvPutRequest(int applicantId, ApplicantCvParameter document)
            : base("Api/Applicant/Cv/" + applicantId, document)
        {
        }
    }

    public class ApplicantCvPostRequest : PostJsonHttpRequestMessage<ApplicantCvResponse>
    {
        public ApplicantCvPostRequest(int applicantId, ApplicantCvParameter document)
            : base("Api/Applicant/Cv/" + applicantId, document)
        {
        }
    }

    public class ApplicantCvDeleteRequest : HttpRequestMessage<ApplicantCvResponse>
    {
        public ApplicantCvDeleteRequest(int applicantId)
            : base(HttpMethod.Delete, "Api/Applicant/Cv/" + applicantId)
        {
        }
    }
}
