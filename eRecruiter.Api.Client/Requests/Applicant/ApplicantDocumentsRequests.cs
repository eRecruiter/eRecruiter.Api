using eRecruiter.Api.Responses;
using System.Collections.Generic;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantDocumentsGetRequest : HttpRequestMessage<IEnumerable<ApplicantDocumentResponse>>
    {
        public ApplicantDocumentsGetRequest(int applicantId)
            : base(HttpMethod.Get, "Api/Applicant/Documents/" + applicantId + "?includeContent=false")
        {
        }
    }
}
