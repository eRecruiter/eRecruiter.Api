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
    public class CompanyImportRequest
    {
        public static async Task Run(ApiHttpClient client, string xmlFileLocation, bool isValidationOnly)
        {
            var xmlString = System.IO.File.ReadAllText(xmlFileLocation);
            var bodyParmeter = new CompanyImportParameter
            {
                XMLContent = Encoding.UTF8.GetBytes(xmlString)
            };

            var companyImportResponse = await new Client.Requests.CompanyImportRequest(isValidationOnly, bodyParmeter).LoadResultAsync(client);
            
            Console.WriteLine(RecursiveResultStringBuilder(companyImportResponse.Result));
        }

        private static string RecursiveResultStringBuilder(SyncResult result)
        {
            var sb = new StringBuilder();
            sb.AppendLine("============================================================================");
            sb.AppendLine(string.Format("{0,-30}{1, -30}", "Type", "Identifiyer"));
            sb.AppendLine("----------------------------------------------------------------------------");
            sb.AppendLine(string.Format("{0,-30}{1, -30}", result.Type, result.Identifiyer));

            var i = 0;
            result.Messages.Select(x => sb.AppendLine(string.Format("{0,4} [{1}] {2}", "#" + i++, x.Severity, x.Text)));
            result.NestedResults.Select(x => sb.AppendLine(RecursiveResultStringBuilder(x)));

            return sb.ToString();
        }
    }
}
