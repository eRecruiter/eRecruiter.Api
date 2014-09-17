using System.Collections.Generic;
using System.Net.Http;
using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantKnowledgesGetRequest : HttpRequestMessage<IEnumerable<ApplicantKnowledgeResponse>>
    {
        public ApplicantKnowledgesGetRequest(int applicantId)
            : base(HttpMethod.Get, "Api/Applicant/Knowledges/" + applicantId)
        {
        }
    }

    public class ApplicantKnowledgesPutRequest : PutJsonHttpRequestMessage<IEnumerable<ApplicantKnowledgeResponse>>
    {
        public ApplicantKnowledgesPutRequest(int applicantId, IEnumerable<ApplicantKnowledgeParameter> knowledges)
            : base("Api/Applicant/Knowledges/" + applicantId, knowledges)
        {
        }
    }

    public class ApplicantKnowledgesPostRequest : PostJsonHttpRequestMessage<IEnumerable<ApplicantKnowledgeResponse>>
    {
        public ApplicantKnowledgesPostRequest(int applicantId, IEnumerable<ApplicantKnowledgeParameter> knowledges)
            : base("Api/Applicant/Knowledges/" + applicantId, knowledges)
        {
        }
    }

    public class ApplicantKnowledgesDeleteRequest : DeleteJsonHttpRequestMessage<IEnumerable<ApplicantKnowledgeResponse>>
    {
        public ApplicantKnowledgesDeleteRequest(int applicantId, IEnumerable<ApplicantKnowledgeParameter> knowledges)
            : base("Api/Applicant/Knowledges/" + applicantId, knowledges)
        {
        }
    }
}
