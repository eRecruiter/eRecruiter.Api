using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantPublicationGetRequest : HttpRequestMessage<ApplicantPublicationResponse>
    {
        public ApplicantPublicationGetRequest(int publicationId)
            : base(HttpMethod.Get, "Api/Applicant/Publication/" + publicationId)
        {
        }
    }

    public class ApplicantPublicationPutRequest : PutJsonHttpRequestMessage<ApplicantPublicationResponse>
    {
        public ApplicantPublicationPutRequest(int applicantId, ApplicantPublicationParameter publication)
            : base("Api/Applicant/Publication/" + applicantId, publication)
        {
        }
    }

    public class ApplicantPublicationPostRequest : PostJsonHttpRequestMessage<ApplicantPublicationResponse>
    {
        public ApplicantPublicationPostRequest(int publicationId, ApplicantPublicationParameter publication)
            : base("Api/Applicant/Publication/" + publicationId, publication)
        {
        }
    }

    public class ApplicantPublicationDeleteRequest : HttpRequestMessage<ApplicantPublicationResponse>
    {
        public ApplicantPublicationDeleteRequest(int publicationId)
            : base(HttpMethod.Delete, "Api/Applicant/Publication/" + publicationId)
        {
        }
    }
}
