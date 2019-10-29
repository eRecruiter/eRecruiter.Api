using eRecruiter.Api.Parameters.Integrations;
using eRecruiter.Api.Responses.Integrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

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
}
