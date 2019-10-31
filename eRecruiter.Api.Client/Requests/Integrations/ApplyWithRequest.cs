using eRecruiter.Api.Parameters.Integrations;
using eRecruiter.Api.Responses.Integrations;
using System;
using System.Net.Http;
using System.Text;

namespace eRecruiter.Api.Client.Requests.Integrations
{
    public class ApplyWithRequest : PostJsonHttpRequestMessage<ApplyWithResponse>
    {
        public ApplyWithRequest(ApplyWithParameter parameter)
            : base("Api/Integrations/ApplyWitheRecruiter", parameter.Body)
        {
            Content = new StringContent(parameter.Body, Encoding.UTF8, "application/json");

            Headers.Add("X-ApplyWith-Signature", parameter.Signature);
        }
    }

    /// <summary>
    /// Request applyWitheRecruiter setting 
    /// </summary>
    public class ApplyWithGetRequest : HttpRequestMessage<ApplyWithSettingResponse>
    {
        /// <summary>
        /// Request applyWitheRecruiter setting based on clientId
        /// </summary>
        /// <param name="clientId"></param>
        public ApplyWithGetRequest(Guid clientId) :
            base(HttpMethod.Get, "Api/Integrations/ApplyWitheRecruiter/" + clientId)
        {
        }
    }
}
