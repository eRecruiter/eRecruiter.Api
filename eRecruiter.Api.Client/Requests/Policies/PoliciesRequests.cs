using eRecruiter.Api.Responses;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    /// <summary>
    /// Request for policies
    /// </summary>
    public class PoliciesGetRequest : HttpRequestMessage<IEnumerable<PolicyResponse>>
    {
        /// <summary>
        /// Returns the current version of each type of Policy
        /// </summary>
        /// <param name="portal">The portal.</param>
        /// <param name="culture">The culture.</param>
        public PoliciesGetRequest(string portal, CultureInfo culture)
            : base(HttpMethod.Get, "Api/Policies?portal" + portal + "&culture=" + culture.Name)
        {
        }
        public PoliciesGetRequest(string portal) : this(portal, CultureInfo.CurrentCulture) { }
    }
}
