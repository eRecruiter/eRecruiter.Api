using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;

namespace eRecruiter.Api.Client.Requests
{
    public class InterestProfilesRequest : HttpRequestMessage<IEnumerable<InterestProfileResponse>>
    {
        /// <summary>
        /// Fetch the 3 best matching interest profiles for the submitted interests.
        /// </summary>
        /// <param name="interests">Interests</param>
        public InterestProfilesRequest(ApplicantInterestParameter interests) : base(HttpMethod.Post, $"Api/ApplicantCompass/InterestProfiles/ForInterests")
        {
            Content = new ObjectContent(typeof (ApplicantInterestParameter), interests, new JsonMediaTypeFormatter());;
        }
    }
}
