using System.Net.Http.Formatting;
using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class ApiKeyRequest : HttpRequestMessage<ApiTokenResponse>
    {
        public ApiKeyRequest(ApiKeyParameter apiKeyParameter)
            : base(HttpMethod.Post, "")
        {
            Content = new ObjectContent(typeof (ApiKeyParameter), apiKeyParameter, new JsonMediaTypeFormatter());
        }
    }
}
