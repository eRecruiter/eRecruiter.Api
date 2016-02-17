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

        [Option("ApiUrl", Required = true, HelpText = "The URL to your API endpoint, for example https://er.erecruiter.net/api.")]
        public string ApiUrl { get; set; }

        [Option("ApplicantId", Required = false, HelpText = "The # of an applicant. Use , (comma) to separate multiple #.")]
        public string ApplicantId { get; set; }

        [Option("GlobalId", Required = false, HelpText = "The gloabl # of an applicant. Use , (comma) to separate multiple #.")]
        public string GlobalId { get; set; }

        [Option("ExternalId", Required = false, HelpText = "The external # of an applicant. Use , (comma) to separate multiple #.")]
        public string ExternalId { get; set; }
        
        [Option("XmlCompanySource", Required = false, HelpText = "The XML with the stored company data.")]
        public string XmlCompanySource { get; set; }

        [Option("IsValidationOnly", Required = false, HelpText = "Test data integration or put data")]
        public bool IsValidationOnly { get; set; }

        [Option("RunMandatorRequests", Required = false, HelpText = "Whether or not to run requests to create/update/delete a mandator (and some related requests).")]
        public bool RunMandatorRequests { get; set; }

        [Option("RunUserRequests", Required = false, HelpText = "Whether or not to run requests to create/update/delete a user (and some related requests).")]
        public bool RunUserRequests { get; set; }

        [Option("RunApplicantRequests", Required = false, HelpText = "Whether or not to run requests to create/update/delete an applicant (and some related requests).")]
        public bool RunApplicantRequests { get; set; }

        [Option("RunApplicantGlobalIdRequests", Required = false, HelpText = "Whether or not to run requests to get applicant Ids from global Ids.")]
        public bool RunApplicantGlobalIdRequests { get; set; }

        [Option("RunApplicantExternalIdRequests", Required = false, HelpText = "Whether or not to run requests to get an applicant Ids from external Ids.")]
        public bool RunApplicantExternalIdRequests { get; set; }

        [Option("RunJobRequests", Required = false, HelpText = "Whether or not to run requests to read job information (and some related requests).")]
        public bool RunJobRequests { get; set; }

        [Option("RunCompanyImport", Required = false, HelpText = "Whether or not to run requests to put company information.")]
        public bool RunCompanyImport { get; set; }



        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this, current => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}
