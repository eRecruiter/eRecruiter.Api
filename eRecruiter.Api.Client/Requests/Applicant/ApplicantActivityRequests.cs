using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantActivityGetRequest : HttpRequestMessage<ApplicantActivityResponse>
    {
        public ApplicantActivityGetRequest(int activityId)
            : base(HttpMethod.Get, "Api/Applicant/Activity/" + activityId)
        {
        }
    }

    public class ApplicantActivityPutRequest : PutJsonHttpRequestMessage<ApplicantActivityResponse>
    {
        public ApplicantActivityPutRequest(int applicantId, ApplicantActivityParameter activity)
            : base("Api/Applicant/Activity/" + applicantId, activity)
        {
        }
    }

    public class ApplicantActivityPostRequest : PostJsonHttpRequestMessage<ApplicantActivityResponse>
    {
        public ApplicantActivityPostRequest(int activityId, ApplicantActivityParameter activity)
            : base("Api/Applicant/Activity/" + activityId, activity)
        {
        }
    }

    public class ApplicantActivityDeleteRequest : HttpRequestMessage<ApplicantActivityResponse>
    {
        public ApplicantActivityDeleteRequest(int activityId)
            : base(HttpMethod.Delete, "Api/Applicant/Activity/" + activityId)
        {
        }
    }
}
