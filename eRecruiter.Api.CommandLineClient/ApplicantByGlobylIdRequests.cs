using eRecruiter.Api.Client;
using eRecruiter.Api.Client.Requests;
using eRecruiter.Utilities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace eRecruiter.Api.CommandLineClient
{
    public static class ApplicantByGlobylIdRequests
    {
        public static async Task Run(ApiHttpClient client, string globalIdsOption)
        {
            foreach (
                var gloablId in
                    (globalIdsOption ?? "").Split(',')
                        .Select(x => x.Trim())
                        .Where(x => x.IsInt())
                        .Select(x => x.GetInt()))
            {
                Console.WriteLine("Loading applicants with globalId #{0} ... ", gloablId);

                var applicants = await new ApplicantGlobalIdGetRequest(gloablId).LoadResultAsync(client);

                foreach (var applicant in applicants)
                {
                    Console.WriteLine("   Applicant #{0}", applicant.Id);
                }
            }
        }
    }
}
