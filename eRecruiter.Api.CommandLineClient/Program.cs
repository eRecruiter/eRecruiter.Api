using eRecruiter.Api.Client;
using eRecruiter.Api.Client.Requests;
using eRecruiter.Api.Parameters;
using System;
using System.Threading.Tasks;

namespace eRecruiter.Api.CommandLineClient
{
    public class Program
    {
        private static readonly CommandlineOptions Options = new CommandlineOptions();

        private static void Main(string[] args)
        {
            Run(args).RunSynchronously();
        }

        private static async Task Run(string[] args)
        {
            if (CommandLine.Parser.Default.ParseArguments(args, Options))
            {
                var tokenCache = new ApiTokenCache();
                var client = new ApiHttpClient(new Uri(Options.ApiUrl),
                    () =>
                        new ApiTokenParameter
                        {
                            ClientInfo = "CommandLineClient",
                            Key = Options.ApiKey,
                            MandatorId = Options.MandatorId
                        },
                    () => tokenCache);

                await Ping(client);

                if (Options.RunMandatorRequests)
                    await MandatorRequests.Run(client);

                if (Options.RunJobRequests)
                    await JobRequests.Run(client);

                if (Options.RunApplicantRequests)
                {
                    await ApplicantRequests.Run(client, Options.ApplicantId);
                    await CvParserRequests.Run(client);
                }

                Console.WriteLine("Everything done. Press < Enter > to exit.");
                Console.ReadLine();
            }


        }

        private static async Task Ping(ApiHttpClient client)
        {
            Console.Write("Pinging ... ");
            var result = await new PingRequest().LoadResultAsync(client);
            Console.WriteLine("{0}, {1}ms", result, client.ElapsedMillisecondsInLastCall);
        }
    }
}
