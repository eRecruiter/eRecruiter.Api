using eRecruiter.Api.Client;
using eRecruiter.Api.Client.Requests;
using eRecruiter.Utilities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace eRecruiter.Api.CommandLineClient
{
    public static class ApplicantsByGlobylIdRequests
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
                Console.Write("Loading applicantIds with globalId #{0} ... ", gloablId);

                var resonse = await new ApplicantsGlobalIdGetRequest(gloablId).LoadResultAsync(client);

                foreach (var applicantId in resonse.ApplicantIds)
                {
                    Console.WriteLine("Applicant #{0}", applicantId);
                }
            }
        }

    }
}
