using System;
using eRecruiter.Api.Client;
using eRecruiter.Api.Client.Requests;
using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using System.Linq;
using System.Threading.Tasks;

namespace eRecruiter.Api.CommandLineClient
{
    public static class UserRequests
    {
        public static async Task Run(ApiHttpClient client)
        {
            UserResponse user;

            using (var logger = new Program.Logger("Loading all users ... ", client))
            {
                var users = await new UsersRequest().LoadResultAsync(client);
                logger.Write("{0} users loaded.", users.Count());
            }

            using (var logger = new Program.Logger("Creating new user ... ", client))
            {
                user = await new UserPutRequest(new UserCreateParameter
                {
                    Email = Guid.NewGuid() + "@server.com",
                    FirstName = "Mario",
                    LastName = "Mustermann",
                    IsEnabled = true,
                    Password = "asdf.QWER.1234"

                }).LoadResultAsync(client);
                logger.Write("User '{0} {1}' created.", user.FirstName, user.LastName);
            }

            using (var logger = new Program.Logger("Loading specific user ... ", client))
            {
                user = await new UserRequest(user.Id).LoadResultAsync(client);
                logger.Write("User '{0} {1}' loaded.", user.FirstName, user.LastName);
            }

            using (var logger = new Program.Logger("Updating user ... ", client))
            {
                user = await new UserPostRequest(user.Id, new UserUpdateParameter
                {
                    FirstName = "Maria",
                    IsEnabled = false,
                    LastName = "Musterfrau"
                }).LoadResultAsync(client);
                logger.Write("User '{0} {1}' updated.", user.FirstName, user.LastName);
            }

            using (var logger = new Program.Logger("Creating user and merging it ... ", client))
            {
                var anotherUser = await new UserPutRequest(new UserCreateParameter
                {
                    Email = Guid.NewGuid() + "@server.com",
                    Password = "asdf.QWER.1234"

                }).LoadResultAsync(client);

                user = await new UserMergeAndDeleteRequest(anotherUser.Id, user.Id).LoadResultAsync(client);
                logger.Write("User '{0} {1}' merged into.", user.FirstName, user.LastName);
            }

            using (var logger = new Program.Logger("Deleting user ... ", client))
            {
                user = await new UserDeleteRequest(user.Id).LoadResultAsync(client);
                logger.Write("User '{0} {1}' deleted.", user.FirstName, user.LastName);
            }
        }
    }
}
