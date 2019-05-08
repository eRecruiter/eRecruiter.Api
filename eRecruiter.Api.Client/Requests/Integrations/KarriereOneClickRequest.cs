using eRecruiter.Api.Responses.Integrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace eRecruiter.Api.Client.Requests.Integrations
{
    public class KarriereOneClickRequest : HttpRequestMessage<KarriereOneClickResponse>
    {
        public KarriereOneClickRequest()
            : base(HttpMethod.Post, "Api/Integrations/KarriereOneClick")
        {
        }
    }
}
