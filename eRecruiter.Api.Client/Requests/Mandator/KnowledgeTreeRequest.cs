using eRecruiter.Api.Responses;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class KnowledgeTreeRequest : HttpRequestMessage<KnowledgeTreeResponse>
    {
        public KnowledgeTreeRequest()
            : base(HttpMethod.Get, "Api/Mandator/KnowledgeTree")
        {
        }
    }
}
