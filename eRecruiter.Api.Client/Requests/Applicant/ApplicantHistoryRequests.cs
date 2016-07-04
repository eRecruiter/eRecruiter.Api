using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantHistoryPutRequest : PutJsonHttpRequestMessage<ApplicantHistoryResponse>
    {
        public ApplicantHistoryPutRequest(int applicantId, ApplicantHistoryParameter history)
            : base("Api/Applicant/History/" + applicantId, history)
        {
        }
    }
}
