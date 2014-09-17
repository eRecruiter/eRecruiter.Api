using CommandLine;
using CommandLine.Text;

namespace eRecruiter.Api.CommandLineClient
{
    public class CommandlineOptions
    {
        [Option("MandatorId", Required = true, HelpText = "The mandator# for your API key.")]
        public int MandatorId { get; set; }

        [Option("ApiKey", Required = true, HelpText = "Your API key.")]
        public string ApiKey { get; set; }

        [Option("ApiUrl", Required = true, HelpText = "The URL to your API endpoint, for example https://er.eRecruiter.net/api.")]
        public string ApiUrl { get; set; }

        [Option("ApplicantId", Required = false, HelpText = "The # of an applicant. Use , (comma) to separate multiple #.")]
        public string ApplicantId { get; set; }
        
        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this, current => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}
