using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRecruiter.Api.Client;
using eRecruiter.Api.Client.Requests;

namespace eRecruiter.Api.CommandLineClient
{
    public static class MandatorRequests
    {
        public static async Task Run(ApiHttpClient client)
        {
            Console.Write("Loading mandator ... ");
            var mandator = await new MandatorRequest(new Uri("http://localhost")).LoadResultAsync(client);
            Console.WriteLine("Mandator '{0}' loaded, {1} ms.", mandator.Name, client.ElapsedMillisecondsInLastCall);

            Console.Write("Loading knowledge tree ... ");
            var knowledgeTree = await new KnowledgeTreeRequest().LoadResultAsync(client);
            Console.WriteLine("Knowledge tree loaded ({0} jobProfiles), {1} ms.", knowledgeTree.JobProfiles.Count(),
                client.ElapsedMillisecondsInLastCall);
        }

    }
}
