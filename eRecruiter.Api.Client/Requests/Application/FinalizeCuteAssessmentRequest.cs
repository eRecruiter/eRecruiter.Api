using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using JetBrains.Annotations;

namespace eRecruiter.Api.Client.Requests
{
    public class FinalizeCuteAssessmentRequest : PostJsonHttpRequestMessage<ApplicationResponse>
    {
        public FinalizeCuteAssessmentRequest(int applicationId, [NotNull] FinalizeCuteAssessmentParameter parameter)
            : base("Api/Application/" + applicationId + "/FinalizeCuteAssessment", parameter)
        {
        }
    }
}
