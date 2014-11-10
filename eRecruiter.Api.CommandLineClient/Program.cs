using eRecruiter.Api.Client;
using eRecruiter.Api.Client.Requests;
using eRecruiter.Api.Parameters;
using eRecruiter.Utilities;
using System;
using System.Threading.Tasks;

namespace eRecruiter.Api.CommandLineClient
{
    public class Program
    {
        private static readonly CommandlineOptions Options = new CommandlineOptions();

        private static void Main(string[] args)
        {
            Run(args).GetAwaiter().GetResult();
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

        /// <summary>
        /// Runs the "ping" request to check if the specified API endpoint is up and running.
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        private static async Task Ping(ApiHttpClient client)
        {
            using (var logger = new Logger("Pinging ... ", client))
            {
                var result = await new PingRequest().LoadResultAsync(client);
                logger.Write("{0}", result);
            }
        }

        /// <summary>
        /// Automatically format console messages and add elapsed time information to them.
        /// </summary>
        public class Logger : IDisposable
        {
            private readonly ApiHttpClient _client;

            public Logger(string message, ApiHttpClient client)
            {
                _client = client;
                if (message.HasValue())
                    Console.Write(message);
            }

            public void Write(string message, params object[] parameters)
            {
                if (message.HasValue())
                {
                    message = string.Format(message, parameters);
                    Console.Write(message);
                }
            }

            public void Dispose()
            {
                Console.WriteLine(" {0} ms.", _client.ElapsedMillisecondsInLastCall);
            }
        }
    }
}
