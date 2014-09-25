using System;
using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class ApplicantGetRequest : HttpRequestMessage<ApplicantResponse>
    {
        public ApplicantGetRequest(string usernameOrEmail, string password)
            : base(
                HttpMethod.Get,
                "Api/Applicant?usernameOrEmail=" + Uri.EscapeDataString(usernameOrEmail) + "&password=" +
                Uri.EscapeDataString(password))
        {
        }

        public ApplicantGetRequest(int applicantId, string logonToken)
            : base(HttpMethod.Get, "Api/Applicant/" + applicantId + "?token=" + Uri.EscapeDataString(logonToken))
        {
        }

        public ApplicantGetRequest(string thirdPartyIdentifier, ThirdParty thirdParty)
            : base(
                HttpMethod.Get,
                "Api/Applicant?identifier=" + Uri.EscapeDataString(thirdPartyIdentifier) + "&thirdParty=" + thirdParty)
        {
        }

        public ApplicantGetRequest(int id)
            : base(HttpMethod.Get, "Api/Applicant/" + id)
        {
        }
    }


    public class ApplicantPutRequest : PutJsonHttpRequestMessage<ApplicantResponse>
    {
        public ApplicantPutRequest(ApplicantParameter applicant, bool sendRegistrationEmail, Uri currentUrl)
            : base("Api/Applicant/?sendRegistrationEmail=" + sendRegistrationEmail + "&url=" + currentUrl, applicant)
        {
        }
    }


    public class ApplicantPostRequest : PostJsonHttpRequestMessage<ApplicantResponse>
    {
        public ApplicantPostRequest(int applicantId, ApplicantParameter applicant)
            : base("Api/Applicant/" + applicantId, applicant)
        {
        }
    }

    public class ApplicantDeleteRequest : HttpRequestMessage<ApplicantResponse>
    {
        /// <summary>
        /// Deletes a specific applicant. You can specify if he/she should be anonymized (default) or completely deleted.
        /// </summary>
        /// <param name="applicantId">The ID of the applicant.</param>
        /// <param name="deleteCompletely">
        /// Whether or not the applicant should be completely deleted from the system. 
        /// Completely deleting an applicant should be rarely necessary, usually he/she should only be anonymized (default).
        /// </param>
        public ApplicantDeleteRequest(int applicantId, bool deleteCompletely = false)
            : base(HttpMethod.Delete, "Api/Applicant/" + applicantId + "?deleteCompletely=" + deleteCompletely)
        {
        }
    }
}
