using System.Net.Http.Formatting;
using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class ApiKeyRequest : HttpRequestMessage<ApiTokenResponse>
    {
        public ApiKeyRequest(ApiTokenParameter apiTokenParameter)
            : base(HttpMethod.Post, "")
        {
            Content = new ObjectContent(typeof (ApiTokenParameter), apiTokenParameter, new JsonMediaTypeFormatter());
        }
    }
}
