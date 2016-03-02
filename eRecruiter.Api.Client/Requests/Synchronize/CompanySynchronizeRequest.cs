using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class CompanySynchronizeRequest :  PutJsonHttpRequestMessage<CompanySynchronizeResponse>
    {
        public CompanySynchronizeRequest(bool isValidationOnly, CompanySynchronizeParameter parameter) : 
            base("Api/Synchronize/Company?isValidationOnly=" + isValidationOnly, parameter)
        {
        }
    }
}
