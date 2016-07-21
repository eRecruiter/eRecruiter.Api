using System;
using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class CvParserRequest : PostJsonHttpRequestMessage<CvParserResponse>
    {
        public CvParserRequest(CvParserParameter param)
            : base("Api/CvParser", param)
        {
        }

        public CvParserRequest(Uri currentUri, CvParserParameter param)
            : base("Api/CvParser?uri=" + currentUri, param)
        {
        }
    }
}
