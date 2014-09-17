using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantExperienceGetRequest : HttpRequestMessage<ApplicantExperienceResponse>
    {
        public ApplicantExperienceGetRequest(int experienceId)
            : base(HttpMethod.Get, "Api/Applicant/Experience/" + experienceId)
        {
        }
    }

    public class ApplicantExperiencePutRequest : PutJsonHttpRequestMessage<ApplicantExperienceResponse>
    {
        public ApplicantExperiencePutRequest(int applicantId, ApplicantExperienceParameter experience)
            : base("Api/Applicant/Experience/" + applicantId, experience)
        {
        }
    }

    public class ApplicantExperiencePostRequest : PostJsonHttpRequestMessage<ApplicantExperienceResponse>
    {
        public ApplicantExperiencePostRequest(int experienceId, ApplicantExperienceParameter experience)
            : base("Api/Applicant/Experience/" + experienceId, experience)
        {
        }
    }

    public class ApplicantExperienceDeleteRequest : HttpRequestMessage<ApplicantExperienceResponse>
    {
        public ApplicantExperienceDeleteRequest(int experienceId)
            : base(HttpMethod.Delete, "Api/Applicant/Experience/" + experienceId)
        {
        }
    }
}
