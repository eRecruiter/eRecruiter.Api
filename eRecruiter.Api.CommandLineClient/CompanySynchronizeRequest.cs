using System;
using System.Collections.Generic;
using System.IO;
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
        public static async Task Run(ApiHttpClient client, string xmlFileLocation, bool isValidationOnly, int requestTimeoutSeconds)
        {
            // Build Body
            var xmlString = File.ReadAllText(xmlFileLocation);
            var bodyParmeter = new CompanySynchronizeParameter
            {
                XMLContent = xmlString
            };

            // Request and await response
            var companyImportResponse = new Client.Requests.CompanySynchronizeRequest(isValidationOnly, requestTimeoutSeconds, bodyParmeter).LoadResult(client);

            // Duration string
            var duration = TimeSpan.FromMilliseconds(client.ElapsedMillisecondsInLastCall);
            var durationString = $"Request took {(int)duration.TotalMinutes}min {duration.Seconds}sec.";

            // Result string
            var resultString = RecursiveResultStringBuilder(companyImportResponse.Result);

            // Stati string
            var statiString = SplitEnumFlags<StatusType>(companyImportResponse.Status).Aggregate(string.Empty, (s, status) => $"{status}, ");

            // Build result string 
            var sb = new StringBuilder();
            sb.AppendLine("========== Duration ==========");
            sb.AppendLine(durationString);
            sb.AppendLine(string.Empty);
            sb.AppendLine("========== Result Stati ==========");
            sb.AppendLine(statiString);
            sb.AppendLine(string.Empty);
            sb.AppendLine("========== Result Import Logs ==========");
            sb.AppendLine(resultString);
            var x = sb.ToString();

            // Print response result
            var logFileName = Path.Combine(Environment.CurrentDirectory, $"CompanyImport_LogInfo_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.txt");
            File.WriteAllText(logFileName, x);

            Console.WriteLine(durationString);
            Console.WriteLine($"See '{logFileName}' for logged information.");
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
