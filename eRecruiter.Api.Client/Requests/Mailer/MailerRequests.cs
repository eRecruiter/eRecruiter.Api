using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using JetBrains.Annotations;

namespace eRecruiter.Api.Client.Requests
{
    public class SendRegistrationMailRequest : PostJsonHttpRequestMessage<RegistrationMailParameter>
    {
        public SendRegistrationMailRequest([NotNull] RegistrationMailParameter parameter) : base("Api/Mailer/Registration", parameter)
        {
        }
    }

    public class SendApplicationMailRequest : PostJsonHttpRequestMessage<ApplicationMailParameter>
    {
        public SendApplicationMailRequest([NotNull] RegistrationMailParameter parameter) : base("Api/Mailer/Application", parameter)
        {
        }
    }

    public class SendDoubleOptInMailRequest : PostJsonHttpRequestMessage<MailerResponse>
    {
        public SendDoubleOptInMailRequest([NotNull] DoubleOptInParameter parameter) : base("Api/Mailer/DoubleOptIn", parameter)
        {
        }
    }
}
