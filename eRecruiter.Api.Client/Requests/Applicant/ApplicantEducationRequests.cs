using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantEducationGetRequest : HttpRequestMessage<ApplicantEducationResponse>
    {
        public ApplicantEducationGetRequest(int educationId)
            : base(HttpMethod.Get, "Api/Applicant/Education/" + educationId)
        {
        }
    }

    public class ApplicantEducationPutRequest : PutJsonHttpRequestMessage<ApplicantEducationResponse>
    {
        public ApplicantEducationPutRequest(int applicantId, ApplicantEducationParameter education)
            : base("Api/Applicant/Education/" + applicantId, education)
        {
        }
    }

    public class ApplicantEducationPostRequest : PostJsonHttpRequestMessage<ApplicantEducationResponse>
    {
        public ApplicantEducationPostRequest(int educationId, ApplicantEducationParameter education)
            : base("Api/Applicant/Education/" + educationId, education)
        {
        }
    }

    public class ApplicantEducationDeleteRequest : HttpRequestMessage<ApplicantEducationResponse>
    {
        public ApplicantEducationDeleteRequest(int educationId)
            : base(HttpMethod.Delete, "Api/Applicant/Education/" + educationId)
        {
        }
    }
}
