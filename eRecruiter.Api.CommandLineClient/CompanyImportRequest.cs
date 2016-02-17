using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRecruiter.Api.Client;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.CommandLineClient
{
    public class CompanyImportRequest
    {
        public static async Task Run(ApiHttpClient client, string xmlFileLocation, bool isTest)
        {
            var inputXml = System.IO.File.ReadAllText(xmlFileLocation);
            var companyImportResponse = await new Client.Requests.CompanyImportRequest(inputXml, isTest).LoadResultAsync(client);


            Console.WriteLine(RecursiveResultStringBuilder(companyImportResponse.Result));
        }

        private static string RecursiveResultStringBuilder(SyncResult result)
        {
            var sb = new StringBuilder();
            sb.AppendLine("============================================================================");
            sb.AppendLine(string.Format("{0,-30}{1, -30}", "Type", "Identifiyer"));
            sb.AppendLine(string.Format("{0,-30}{1, -30}", result.Type, result.Identifiyer));

            var i = 0;
            foreach (var message in result.Messages)
            {
                sb.AppendLine(string.Format("#{0,-3}: {1}", i++, message));
            }

            foreach (var nestedResult in result.NestedResults)
            {
                sb.AppendLine(RecursiveResultStringBuilder(nestedResult));
            }

            return sb.ToString();
        }
    }
}
