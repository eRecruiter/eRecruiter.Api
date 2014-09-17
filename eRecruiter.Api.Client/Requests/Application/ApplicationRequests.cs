using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using JetBrains.Annotations;
using System;

namespace eRecruiter.Api.Client.Requests
{
    public class CreateApplicationRequest : PutJsonHttpRequestMessage<ApplicationCreateResponse>
    {
        public CreateApplicationRequest([NotNull] ApplicationCreateParameter parameter, bool sendApplicationEmail, [CanBeNull] Uri currentUrl)
            : base("Api/Application/?sendApplicationEmail=" + sendApplicationEmail + "&url=" + currentUrl, parameter)
        {
        }
    }

    public class UpdateApplicationRequest : PostJsonHttpRequestMessage<ApplicationResponse>
    {
        public UpdateApplicationRequest(int applicationId, [NotNull] ApplicationUpdateParameter parameter)
            : base("Api/Application/" + applicationId, parameter)
        {
        }
    }
}
