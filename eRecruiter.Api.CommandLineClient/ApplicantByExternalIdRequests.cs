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
                Console.WriteLine("Loading applicantId with externalId #{0} ... ", externalId);

                var applicant = await new ApplicantExternalIdGetRequest(externalId).LoadResultAsync(client);

                if (applicant != null)
                {
                    Console.WriteLine("   Applicant #{0}, Mandator #{1}", applicant.ApplicantId, applicant.MandatorId);
                }
                else
                {
                    Console.WriteLine("   Couldn't find applicant");
                }
            }
        }
    }
}
