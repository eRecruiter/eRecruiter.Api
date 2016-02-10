using System.Threading;
using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using JetBrains.Annotations;

namespace eRecruiter.Api.Client.Requests
{
    public class SendRegistrationMailRequest : PostJsonHttpRequestMessage<MailerResponse>
    {
        public SendRegistrationMailRequest([NotNull] RegistrationMailParameter parameter) : base("Api/Mailer/Registration", parameter)
        {
        }
    }

    public class SendApplicationMailRequest : PostJsonHttpRequestMessage<MailerResponse>
    {
        public SendApplicationMailRequest([NotNull] RegistrationMailParameter parameter) : base("Api/Mailer/Application", parameter)
        {
        }
    }

    public class SendDoubleOptInMailRequest : PostJsonHttpRequestMessage<MailerResponse>
    {
        public SendDoubleOptInMailRequest([NotNull] DoubleOptInParameter parameter) : base("Api/Mailer/DoubleOptIn?culture=" + Thread.CurrentThread.CurrentUICulture, parameter)
        {
        }
    }
}
