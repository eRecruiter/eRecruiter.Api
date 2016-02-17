using System.Net.Http;
using System.Text;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class CompanyImportRequest :  HttpRequestMessage<CompanyImportResponse>
    {
        public CompanyImportRequest(string inputXml, bool isTest) : base(HttpMethod.Put, "Api/Import/Company?isTest=" + isTest)
        {
            Content = new StringContent(inputXml, Encoding.UTF8);
        }
    }
}
