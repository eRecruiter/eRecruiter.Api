using System;
using eRecruiter.Api.Parameters;

namespace eRecruiter.Api.Client.Requests
{
    public class FeedbackRequest : PutJsonHttpRequestMessage<string>
    {
        public FeedbackRequest(FeedbackParameter feedback, Uri url)
            : base("Api/Feedback?url=" + url, feedback)
        {
        }
    }
}
