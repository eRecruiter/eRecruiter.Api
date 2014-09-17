using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantLanguageGetRequest : HttpRequestMessage<ApplicantLanguageResponse>
    {
        public ApplicantLanguageGetRequest(int languageId)
            : base(HttpMethod.Get, "Api/Applicant/Language/" + languageId)
        {
        }
    }

    public class ApplicantLanguagePutRequest : PutJsonHttpRequestMessage<ApplicantLanguageResponse>
    {
        public ApplicantLanguagePutRequest(int applicantId, ApplicantLanguageParameter language)
            : base("Api/Applicant/Language/" + applicantId, language)
        {
        }
    }

    public class ApplicantLanguagePostRequest : PostJsonHttpRequestMessage<ApplicantLanguageResponse>
    {
        public ApplicantLanguagePostRequest(int languageId, ApplicantLanguageParameter language)
            : base("Api/Applicant/Language/" + languageId, language)
        {
        }
    }

    public class ApplicantLanguageDeleteRequest : HttpRequestMessage<ApplicantLanguageResponse>
    {
        public ApplicantLanguageDeleteRequest(int languageId)
            : base(HttpMethod.Delete, "Api/Applicant/Language/" + languageId)
        {
        }
    }
}
