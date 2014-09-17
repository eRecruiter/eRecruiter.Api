using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantKnowledgeGetRequest : HttpRequestMessage<ApplicantKnowledgeResponse>
    {
        public ApplicantKnowledgeGetRequest(int applicantId, string knowledge)
            : base(HttpMethod.Get, "Api/Applicant/Knowledge/" + applicantId + "/" + knowledge)
        {
        }
    }

    public class ApplicantKnowledgePutRequest : PutJsonHttpRequestMessage<ApplicantKnowledgeResponse>
    {
        public ApplicantKnowledgePutRequest(int applicantId, ApplicantKnowledgeParameter knowledge)
            : base("Api/Applicant/Knowledge/" + applicantId, knowledge)
        {
        }
    }

    public class ApplicantKnowledgePostRequest : PostJsonHttpRequestMessage<ApplicantKnowledgeResponse>
    {
        public ApplicantKnowledgePostRequest(int applicantId, ApplicantKnowledgeParameter knowledge)
            : base("Api/Applicant/Knowledge/" + applicantId, knowledge)
        {
        }
    }

    public class ApplicantKnowledgeDeleteRequest : DeleteJsonHttpRequestMessage<ApplicantKnowledgeResponse>
    {
        public ApplicantKnowledgeDeleteRequest(int applicantId, string knowledge)
            : base("Api/Applicant/Knowledge/" + applicantId, knowledge)
        {
        }
    }
}
