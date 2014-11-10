using System.Collections.Generic;
using System.Net.Http;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.Client.Requests
{
    public class UsersRequest : HttpRequestMessage<IEnumerable<UserResponse>>
    {
        public UsersRequest()
            : base(HttpMethod.Get, "Api/Users/")
        {
        }
    }
}
