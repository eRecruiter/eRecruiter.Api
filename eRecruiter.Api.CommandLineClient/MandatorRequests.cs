using System;
using eRecruiter.Api.Client;
using eRecruiter.Api.Client.Requests;
using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using System.Linq;
using System.Threading.Tasks;

namespace eRecruiter.Api.CommandLineClient
{
    public static class MandatorRequests
    {
        public static async Task Run(ApiHttpClient client)
        {
            MandatorResponse mandator;

            using (var logger = new Program.Logger("Loading current mandator ... ",client))
            {
                mandator = await new MandatorRequest().LoadResultAsync(client);
                logger.Write("Mandator '{0}' loaded.", mandator.Name);
            }

            using (var logger = new Program.Logger("Loading knowledge tree ... ", client))
            {
                var knowledgeTree = await new KnowledgeTreeRequest().LoadResultAsync(client);
                logger.Write("Knowledge tree loaded ({0} jobProfiles).", knowledgeTree.JobProfiles.Count());
            }

            using (var logger = new Program.Logger("Loading all mandators ... ", client))
            {
                var mandators = await new MandatorsRequest().LoadResultAsync(client);
                logger.Write("{0} mandators loaded.", mandators.Count());
            }

            using (var logger = new Program.Logger("Creating new mandator ... ", client))
            {
                mandator = await new MandatorPutRequest(new MandatorCreateParameter
                {
                    Name = "My new mandator " + Guid.NewGuid()
                }).LoadResultAsync(client);
                logger.Write("Mandator '{0}' created.", mandator.Name);
            }

            using (var logger = new Program.Logger("Updating mandator ... ", client))
            {
                mandator = await new MandatorPostRequest(mandator.Id, new MandatorUpdateParameter
                {
                    Name = "My new name " + Guid.NewGuid()
                }).LoadResultAsync(client);
                logger.Write("Mandator '{0}' updated.", mandator.Name);
            }

            using (var logger = new Program.Logger("Deleting mandator ... ", client))
            {
                mandator = await new MandatorDeleteReqeust(mandator.Id).LoadResultAsync(client);
                logger.Write("Mandator '{0}' deleted.", mandator.Name);
            }
        }

    }
}
