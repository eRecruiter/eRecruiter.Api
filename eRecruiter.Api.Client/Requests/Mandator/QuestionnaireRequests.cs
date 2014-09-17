using eRecruiter.Api.Responses;
using System.Globalization;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class QuestionnaireRequest : HttpRequestMessage<QuestionnaireResponse>
    {
        public QuestionnaireRequest(int id)
            : base(HttpMethod.Get, "Api/Questionnaire/" + id)
        {
        }
    }

    public class QuestionnaireByJobRequest : HttpRequestMessage<QuestionnaireResponse>
    {
        public QuestionnaireByJobRequest(int jobId)
            : base(HttpMethod.Get, "Api/Questionnaire/ByJob/" + jobId + "?culture=" + CultureInfo.CurrentUICulture)
        {
        }
    }
}
