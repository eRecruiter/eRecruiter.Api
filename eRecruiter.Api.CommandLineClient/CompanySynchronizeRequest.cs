using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRecruiter.Api.Client;
using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;

namespace eRecruiter.Api.CommandLineClient
{
    public class CompanySynchronizeRequest
    {
        public static async Task Run(ApiHttpClient client, string xmlFileLocation, bool isValidationOnly)
        {
            // Build Body
            var xmlString = System.IO.File.ReadAllText(xmlFileLocation);
            var bodyParmeter = new CompanySynchronizeParameter
            {
                XMLContent = xmlString
            };

            // Request and await response
            var companyImportResponse = await new Client.Requests.CompanySynchronizeRequest(isValidationOnly, bodyParmeter).LoadResultAsync(client);
            
            // Print response result
            Console.WriteLine(RecursiveResultStringBuilder(companyImportResponse.Result));

            // Print response stati
            Console.WriteLine("========== Stati ==========");
            var stati = SplitEnumFlags<StatusType>(companyImportResponse.Status);
            stati.ToList().ForEach(x => Console.WriteLine(x));
        }

        private static IEnumerable<T> SplitEnumFlags<T>(Enum mask)
        {
            return Enum.GetValues(typeof(T)).Cast<Enum>().Where(mask.HasFlag).Cast<T>().ToList();
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
                sb.AppendLine(string.Format("{0,4} [{1}] {2}", "#" + i++, message.Severity, message.Text));
            }

            foreach (var nestedResult in result.NestedResults)
            {
                sb.AppendLine(RecursiveResultStringBuilder(nestedResult));
            }

            return sb.ToString();
        }
    }
}
