using System;
using System.Linq;
using System.Threading.Tasks;
using eRecruiter.Api.Client;
using eRecruiter.Api.Client.Requests.Application;

namespace eRecruiter.Api.CommandLineClient
{
    public class ReferrerRequests
    {
        public static async Task Run(ApiHttpClient client, string referrer)
        {
            // fetch the applications for the referrer
            var applications = (await new ApplicationsByReferrerRequests(referrer, DateTime.Now.AddDays(-7)).LoadResultAsync(client)).ToList();

            // print the number of results
            Console.WriteLine($"Retrieved {applications.Count} applications for referrer {referrer}");
            Console.WriteLine("---------------------------------------------------------------------------");

            // print the results
            foreach (var application in applications)
            {
                Console.WriteLine($"#{application.ApplicantId}, #{application.ApplicationId}, {application.JobId}, " +                                  
                                  $"{application.Gender}, {application.TitleBeforeName}, {application.FirstName}, " +
                                  $"{application.LastName}, {application.TitleAfterName}, {application.Referrer}, " +
                                  $"{application.ReferrerAdditionalInformation}, {application.WorkflowStatusGroup}, " +
                                  $"{application.WorkflowLastChange:O}");
            }
        }
    }
}