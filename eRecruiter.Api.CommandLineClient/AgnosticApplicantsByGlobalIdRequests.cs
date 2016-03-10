using System;
using System.Linq;
using System.Threading.Tasks;
using eRecruiter.Api.Client;
using eRecruiter.Api.Client.Requests;
using eRecruiter.Utilities;

namespace eRecruiter.Api.CommandLineClient
{
    public static class AgnosticApplicantsByGlobalIdRequests
    {
        public static async Task Run(ApiHttpClient client, string globalIdsOption)
        {
            foreach (
                var globalId in
                    (globalIdsOption ?? "").Split(',')
                        .Select(x => x.Trim())
                        .Where(x => x.IsInt())
                        .Select(x => x.GetInt()))
            {
                Console.WriteLine("Loading applicants for all mandators with globalId #{0} ... ", globalId);

                var applicants = await new AgnosticApplicantsByGlobalIdRequest(globalId).LoadResultAsync(client);

                foreach (var applicant in applicants)
                {
                    Console.WriteLine("   Applicant #{0} / Mandator #{1}", applicant.Id, applicant.MandatorId);
                }
            }
        }
    }
}