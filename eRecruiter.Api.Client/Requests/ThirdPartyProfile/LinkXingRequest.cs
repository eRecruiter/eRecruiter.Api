using System;
using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class LinkXingRequest : HttpRequestMessage<ApplicantResponse>
    {
        public LinkXingRequest(int id, string thirdPartyIdentifier, Uri profileUrl)
            : base(HttpMethod.Post, "Api/Applicant/Xing/" + id + "?identifier=" + thirdPartyIdentifier + "&profileUrl=" + profileUrl)
        {
        }
    }
}
