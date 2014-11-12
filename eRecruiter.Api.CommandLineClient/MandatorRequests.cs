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

            using (var logger = new Program.Logger("Loading current mandator ... ", client))
            {
                mandator = await new MandatorRequest().LoadResultAsync(client);
                logger.Write("Mandator '{0}' loaded.", mandator.Name);
            }

            using (var logger = new Program.Logger("Re-loading current mandator (should hit cache) ... ", client))
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

            await RunApiKeyRequests(client, mandator.Id);

            using (var logger = new Program.Logger("Creating new mandator ... ", client))
            {
                mandator = await new MandatorPutRequest(new MandatorCreateParameter
                {
                    Name = "My new mandator " + Guid.NewGuid()
                }).LoadResultAsync(client);
                logger.Write("Mandator '{0}' created.", mandator.Name);
            }

            using (var logger = new Program.Logger("Loading specific mandator ... ", client))
            {
                mandator = await new MandatorRequest(mandator.Id).LoadResultAsync(client);
                logger.Write("Mandator '{0}' loaded.", mandator.Name);
            }

            using (var logger = new Program.Logger("Re-loading specific mandator (should hit cache) ... ", client))
            {
                mandator = await new MandatorRequest(mandator.Id).LoadResultAsync(client);
                logger.Write("Mandator '{0}' loaded.", mandator.Name);
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
                mandator = await new MandatorDeleteRequest(mandator.Id).LoadResultAsync(client);
                logger.Write("Mandator '{0}' deleted.", mandator.Name);
            }
        }

        private static async Task RunApiKeyRequests(ApiHttpClient client, int mandatorId)
        {
            using (var logger = new Program.Logger("Loading all API keys ... ", client))
            {
                var apiKeys = await new ApiKeysRequest().LoadResultAsync(client);
                logger.Write("{0} keys loaded.", apiKeys.Count());
            }

            using (var logger = new Program.Logger("Loading API keys for specific mandator ... ", client))
            {
                var apiKeys = await new ApiKeysRequest(mandatorId).LoadResultAsync(client);
                logger.Write("{0} keys loaded.", apiKeys.Count());
            }

            ApiKeyResponse apiKey;
            using (var logger = new Program.Logger("Creating new API key ... ", client))
            {
                apiKey = await new ApiKeyPutRequest(new ApiKeyCreateParameter
                {
                    Name = "My new key",
                    MandatorId = mandatorId,
                    IsEnabled = true
                }).LoadResultAsync(client);
                logger.Write("API key '{0}' created.", apiKey.Name);
            }

            using (var logger = new Program.Logger("Updating API key ... ", client))
            {
                apiKey = await new ApiKeyPostRequest(apiKey.Id, new ApiKeyUpdateParameter
                {
                    Name = apiKey.Name + " *updated*",
                    IsEnabled = false,
                    AccessLevels = new[] {ApiKeyAccessLevel.Jobs, ApiKeyAccessLevel.Applicants}
                }).LoadResultAsync(client);
                logger.Write("API key '{0}' updated.", apiKey.Name);
            }

            using (var logger = new Program.Logger("Deleting API key ... ", client))
            {
                apiKey = await new ApiKeyDeleteReqeust(apiKey.Id).LoadResultAsync(client);
                logger.Write("API key '{0}' deleted.", apiKey.Name);
            }
        }
    }
}
