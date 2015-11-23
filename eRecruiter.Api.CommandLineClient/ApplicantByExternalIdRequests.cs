using eRecruiter.Api.Client;
using eRecruiter.Utilities;
using System;
using System.Linq;
using System.Threading.Tasks;
using eRecruiter.Api.Client.Requests;

namespace eRecruiter.Api.CommandLineClient
{
    public static class ApplicantByExternalIdRequests
    {
        public static async Task Run(ApiHttpClient client, string externalIdsOption)
        {
            foreach (
                var externalId in
                    (externalIdsOption ?? "").Split(',')
                        .Select(x => x.Trim())
                        .Where(x => x.IsInt())
                        .Select(x => x.GetInt()))
            {
                Console.WriteLine("Loading applicants with externalId #{0} ... ", externalId);

                var applicants = await new ApplicantExternalIdGetRequest(externalId).LoadResultAsync(client);

                foreach (var applicant in applicants)
                {
                    Console.WriteLine("   Applicant #{0}", applicant.Id);
                }
            }
        }
    }
}
