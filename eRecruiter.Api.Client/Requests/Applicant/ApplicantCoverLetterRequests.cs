using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantCoverLetterPutRequest : PutJsonHttpRequestMessage<ApplicantResponse>
    {
        public ApplicantCoverLetterPutRequest(int applicantId, ApplicantCoverLetterCreateParameter param)
            : base("Api/Applicant/CoverLetter/" + applicantId, param)
        {
        }
    }
}
