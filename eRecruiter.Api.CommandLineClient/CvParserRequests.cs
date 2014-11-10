using eRecruiter.Api.Client;
using eRecruiter.Api.Client.Requests;
using eRecruiter.Api.Parameters;
using System;
using System.IO;
using System.Threading.Tasks;

namespace eRecruiter.Api.CommandLineClient
{
    public static class CvParserRequests
    {
        public static async Task Run(ApiHttpClient client)
        {
            Console.Write("Calling CV-Parser ...");
            var param = new CvParserParameter
            {
                Content = File.ReadAllBytes("Lebenslauf.pdf"),
                FileName = "Lebenslauf.pdf"
            };
            var result = await new CvParserRequest(param).LoadResultAsync(client);
            Console.WriteLine("Found last name '{0}', {1}ms", result.LastName, client.ElapsedMillisecondsInLastCall);
        }

    }
}
