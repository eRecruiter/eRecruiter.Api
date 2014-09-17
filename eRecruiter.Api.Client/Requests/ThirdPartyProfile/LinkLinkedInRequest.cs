using System;
using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class LinkLinkedInRequest : HttpRequestMessage<ApplicantResponse>
    {
        public LinkLinkedInRequest(int id, string thirdPartyIdentifier, Uri profileUrl)
            : base(HttpMethod.Post, "Api/Applicant/LinkedIn/" + id + "?identifier=" + thirdPartyIdentifier + "&profileUrl=" + profileUrl)
        {
        }
    }
}
