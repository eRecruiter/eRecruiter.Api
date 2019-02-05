using eRecruiter.Api.Responses;
using System.Globalization;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class CompassQuestionsRequest : HttpRequestMessage<CompassQuestionsResponse>
    {
        public CompassQuestionsRequest() : this(CultureInfo.CurrentUICulture.Name)
        {
        }

        public CompassQuestionsRequest(string culture) : base(HttpMethod.Get, $"Api/ApplicantCompass/Questions?culture={culture}")
        {
        }
    }
}
