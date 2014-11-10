using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class UserGetRequest : HttpRequestMessage<UserResponse>
    {
        public UserGetRequest(int userId)
            : base(HttpMethod.Get, "Api/User/" + userId)
        {
        }
    }

    public class UserPutRequest : PutJsonHttpRequestMessage<UserResponse>
    {
        public UserPutRequest(UserCreateParameter user)
            : base("Api/User/", user)
        {
        }
    }

    public class UserPostRequest : PostJsonHttpRequestMessage<UserResponse>
    {
        public UserPostRequest(int userId, UserUpdateParameter user)
            : base("Api/User/" + userId, user)
        {
        }
    }

    public class UserDeleteReqeust : HttpRequestMessage<UserResponse>
    {
        public UserDeleteReqeust(int userId)
            : base(HttpMethod.Delete, "Api/User/" + userId)
        {
        }
    }

    public class UserMergeAndDeleteReqeust : HttpRequestMessage<UserResponse>
    {
        /// <summary>
        /// Merges user A with user B (moves all data from A to B), then deletes A.
        /// </summary>
        /// <param name="userId">The user ID to move data away from and delete (user A).</param>
        /// <param name="mergeWithUserId">The userID to move data to (user B).</param>
        public UserMergeAndDeleteReqeust(int userId, int mergeWithUserId)
            : base(HttpMethod.Delete, "Api/User/Merge/" + userId + "&mergeWithUserId=" + mergeWithUserId)
        {
        }
    }
}
