using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantCustomFieldGetRequest : HttpRequestMessage<CustomFieldValueResponse>
    {
        public ApplicantCustomFieldGetRequest(int applicantId, string customFieldName)
            : base(HttpMethod.Get, "Api/Applicant/" + applicantId + "/CustomField/" + customFieldName)
        {
        }
    }


    public class ApplicantCustomFieldPostRequest : PostJsonHttpRequestMessage<CustomFieldValueResponse>
    {
        public ApplicantCustomFieldPostRequest(int applicantId, CustomFieldValueParameter customField)
            : base("Api/Applicant/" + applicantId + "/CustomField", customField)
        {
        }
    }


    public class ApplicantCustomFieldDeleteRequest : HttpRequestMessage<CustomFieldValueResponse>
    {
        public ApplicantCustomFieldDeleteRequest(int applicantId, string customFieldName)
            : base(HttpMethod.Delete, "Api/Applicant/" + applicantId + "/CustomField/" + customFieldName)
        {
        }
    }
}
