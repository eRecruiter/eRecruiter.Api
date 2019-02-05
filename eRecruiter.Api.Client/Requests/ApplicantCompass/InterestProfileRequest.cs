using eRecruiter.Api.Responses;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class InterestProfileRequest : HttpRequestMessage<InterestProfileResponse>
    {
        /// <summary>
        /// Fetch an interest profile by its ID
        /// </summary>
        /// <param name="interestProfileId">Interest Profile ID</param>
        public InterestProfileRequest(int interestProfileId) : base(HttpMethod.Get, $"Api/ApplicantCompass/InterestProfile/{interestProfileId}")
        {
        }
    }
}
