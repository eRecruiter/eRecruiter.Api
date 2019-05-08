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
    public class KarriereOneClickRequest : PostJsonHttpRequestMessage<KarriereOneClickResponse>
    {
        public KarriereOneClickRequest(KarriereOneClickParameter parameter)
            : base("Api/Integrations/KarriereOneClick", parameter.Body)
        {
            Headers.Add("X-Karriere-Signature", parameter.Signature);
        }
    }
}
