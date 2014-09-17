using System.Collections.Generic;
using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantCustomFieldsGetRequest : HttpRequestMessage<IEnumerable<CustomFieldValueResponse>>
    {
        public ApplicantCustomFieldsGetRequest(int applicantId)
            : base(HttpMethod.Get, "Api/Applicant/CustomFields/" + applicantId)
        {
        }
    }
}
