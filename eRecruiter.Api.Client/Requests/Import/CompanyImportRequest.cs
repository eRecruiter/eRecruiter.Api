using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class CompanyImportRequest :  PutJsonHttpRequestMessage<CompanyImportResponse>
    {
        public CompanyImportRequest(bool isValidationOnly, CompanyImportParameter parameter) : 
            base("Api/Import/Company?isTest=" + isValidationOnly, parameter)
        {
        }
    }
}
