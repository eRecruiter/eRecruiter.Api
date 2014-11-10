using eRecruiter.Api.Client;
using eRecruiter.Api.Client.Requests;
using eRecruiter.Api.Parameters;
using eRecruiter.Api.Responses;
using eRecruiter.Utilities;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace eRecruiter.Api.CommandLineClient
{
    internal class Program
    {
        private static readonly CommandlineOptions Options = new CommandlineOptions();

        private static void Main(string[] args)
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

                var methodsToCall = new Func<ApiHttpClient, Task>[]
                {
                    Ping,
                    Mandator,
                    Jobs,
                    Applicant,
                    CvParser
                };

                foreach (var method in methodsToCall)
                {
                    method.Invoke(client).GetAwaiter().GetResult();
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Press < Enter > to exit.");
            Console.ReadLine();
        }

        private static async Task Ping(ApiHttpClient client)
        {
            Console.Write("Pinging ... ");
            var result = await new PingRequest().LoadResultAsync(client);
            Console.WriteLine("{0}, {1}ms", result, client.ElapsedMillisecondsInLastCall);
        }

        private static async Task CvParser(ApiHttpClient client)
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

        private static async Task Mandator(ApiHttpClient client)
        {
            Console.Write("Loading mandator ... ");
            var mandator = await new MandatorRequest(new Uri("http://localhost")).LoadResultAsync(client);
            Console.WriteLine("Mandator '{0}' loaded, {1} ms.", mandator.Name, client.ElapsedMillisecondsInLastCall);

            Console.Write("Loading knowledge tree ... ");
            var knowledgeTree = await new KnowledgeTreeRequest().LoadResultAsync(client);
            Console.WriteLine("Knowledge tree loaded ({0} jobProfiles), {1} ms.", knowledgeTree.JobProfiles.Count(),
                client.ElapsedMillisecondsInLastCall);
        }

        private static async Task Jobs(ApiHttpClient client)
        {
            Console.Write("Loading jobs ... ");
            var jobs = await new PublishedJobsRequest(null).LoadResultAsync(client);
            Console.WriteLine("{0} jobs published, {1}ms.", jobs.Jobs.Count(), client.ElapsedMillisecondsInLastCall);

            long millisecondsSum = 0;
            Console.Write("Loading all the jobs that are published via GetPublishedJob ... ");
            foreach (var jobId in jobs.Jobs.Select(x => x.Id))
            {
                await new PublishedJobRequest(jobId).LoadResultAsync(client);
                millisecondsSum += client.ElapsedMillisecondsInLastCall;
            }
            Console.WriteLine("{0}ms average", millisecondsSum / jobs.Jobs.Count());

            millisecondsSum = 0;
            Console.Write("Loading all the jobs that are published via GetJob ... ");
            foreach (var jobId in jobs.Jobs.Select(x => x.Id))
            {
                await new JobRequest(jobId).LoadResultAsync(client);
                millisecondsSum += client.ElapsedMillisecondsInLastCall;
            }
            Console.WriteLine("{0}ms average", millisecondsSum / jobs.Jobs.Count());

            Console.Write("Loading questionnaires for all jobs that have one ... ");
            var questionnaireStopwatch = new Stopwatch();
            questionnaireStopwatch.Start();
            var questionnaireCount = 0;
            var questionnaireItemsCount = 0;
            foreach (var job in jobs.Jobs.Where(x => x.HasQuestionnaire))
            {
                // load by job
                var questionnaire = await new QuestionnaireByJobRequest(job.Id).LoadResultAsync(client);

                // load the same questionnaire by ID as well
                questionnaire = await new QuestionnaireRequest(questionnaire.Id).LoadResultAsync(client);
                questionnaireCount++;
                questionnaireItemsCount += questionnaire.Items.Count();
            }

            questionnaireStopwatch.Stop();
            if (questionnaireStopwatch.ElapsedMilliseconds <= 0 || questionnaireCount <= 0)
                Console.WriteLine("none found.");
            else
                Console.WriteLine("{0} questionnaires loaded with {1} items total, {2}ms average per questionnaire.",
                    questionnaireCount, questionnaireItemsCount,
                    questionnaireStopwatch.ElapsedMilliseconds / questionnaireCount);
        }

        private static async Task Applicant(ApiHttpClient client)
        {
            foreach (
                var applicantId in
                    (Options.ApplicantId ?? "").Split(',')
                        .Select(x => x.Trim())
                        .Where(x => x.IsInt())
                        .Select(x => x.GetInt()))
            {
                Console.Write("Loading applicant #{0} ... ", applicantId);

                var applicant = await new ApplicantGetRequest(applicantId).LoadResultAsync(client);
                Console.WriteLine("Applicant '{0}', {1}ms.", applicant.FirstName + " " + applicant.LastName,
                    client.ElapsedMillisecondsInLastCall);

                var savedApplicant = await new ApplicantPostRequest(applicant.Id, applicant).LoadResultAsync(client);
                Console.WriteLine("Updated Applicant '{0}', {1}ms.",
                    savedApplicant.FirstName + " " + savedApplicant.LastName, client.ElapsedMillisecondsInLastCall);

                var documents = await new ApplicantDocumentsGetRequest(applicantId).LoadResultAsync(client);
                Console.WriteLine("{0} documents loaded, {1}ms.", documents.Count(),
                    client.ElapsedMillisecondsInLastCall);

                var activities = await new ApplicantActivitiesGetRequest(applicantId).LoadResultAsync(client);
                Console.WriteLine("{0} activities loaded, {1}ms.", activities.Count(),
                    client.ElapsedMillisecondsInLastCall);

                var publications = await new ApplicantPublicationsGetRequest(applicantId).LoadResultAsync(client);
                Console.WriteLine("{0} publications loaded, {1}ms.", publications.Count(),
                    client.ElapsedMillisecondsInLastCall);

                var certificates = await new ApplicantCertificatesGetRequest(applicantId).LoadResultAsync(client);
                Console.WriteLine("{0} certificates loaded, {1}ms.", certificates.Count(),
                    client.ElapsedMillisecondsInLastCall);

                var educations = await new ApplicantEducationsGetRequest(applicantId).LoadResultAsync(client);
                Console.WriteLine("{0} educations loaded, {1}ms.", educations.Count(),
                    client.ElapsedMillisecondsInLastCall);

                var experiences = await new ApplicantExperiencesGetRequest(applicantId).LoadResultAsync(client);
                Console.WriteLine("{0} experiences loaded, {1}ms.", experiences.Count(),
                    client.ElapsedMillisecondsInLastCall);

                var languages = await new ApplicantLanguagesGetRequest(applicantId).LoadResultAsync(client);
                Console.WriteLine("{0} languages loaded, {1}ms.", languages.Count(),
                    client.ElapsedMillisecondsInLastCall);

                var customFields =
                    (await new ApplicantCustomFieldsGetRequest(applicantId).LoadResultAsync(client)).ToList();
                Console.WriteLine("{0} custom fields loaded, {1}ms.", customFields.Count(),
                    client.ElapsedMillisecondsInLastCall);

                var knowledges = (await new ApplicantKnowledgesGetRequest(applicantId).LoadResultAsync(client)).ToList();
                Console.WriteLine("{0} knowledges loaded, {1}ms.", knowledges.Count(),
                    client.ElapsedMillisecondsInLastCall);

                var knowledge =
                    (await
                        new ApplicantKnowledgeGetRequest(applicantId, knowledges.First().Knowledge).LoadResultAsync(
                            client));
                Console.WriteLine("Knowledge {0} loaded, {1}ms.", knowledge.Knowledge,
                    client.ElapsedMillisecondsInLastCall);

                var mandator = await new MandatorRequest(new Uri("http://localhost")).LoadResultAsync(client);
                knowledge.Level = mandator.KnowledgeLevels.Last();
                await new ApplicantKnowledgePutRequest(applicantId, knowledge).LoadResultAsync(client);
                Console.WriteLine("Knowledge updated, {0}ms.", client.ElapsedMillisecondsInLastCall);

                Console.WriteLine("Loading, updating and deleting custom fields ...");
                foreach (var customField in customFields)
                {
                    if (customField.CustomField.Type == CustomFieldResponse.CustomFieldType.TextMultiLine ||
                        customField.CustomField.Type == CustomFieldResponse.CustomFieldType.TextSingleLine)
                        await
                            new ApplicantCustomFieldPostRequest(applicantId,
                                new CustomFieldValueParameter
                                {
                                    CustomField = customField.CustomField.Name,
                                    Value = Guid.NewGuid().ToString()
                                }).LoadResultAsync(client);

                    await
                        new ApplicantCustomFieldGetRequest(applicantId, customField.CustomField.Name).LoadResultAsync(
                            client);
                    await
                        new ApplicantCustomFieldDeleteRequest(applicantId, customField.CustomField.Name).LoadResultAsync
                            (client);
                }

                if (applicant.HasPhoto)
                {
                    var photo = await new ApplicantPhotoGetRequest(applicantId).LoadResultAsync(client);
                    Console.WriteLine("{0}, {1}ms.", photo != null ? "Photo loaded" : "No Photo loaded",
                        client.ElapsedMillisecondsInLastCall);
                }


                await
                    new ApplicantCoverLetterPutRequest(applicantId,
                        new ApplicantCoverLetterCreateParameter(null, "Some cover letter")).LoadResultAsync(client);
                Console.WriteLine("{0}, {1}ms.", "Cover Letter added", client.ElapsedMillisecondsInLastCall);

                await
                    new ResetPasswordRequest(applicantId, new ApplicantResetPasswordParameter("asdf", null))
                        .LoadResultAsync(client);
                Console.WriteLine("Password reset, {0}ms.", client.ElapsedMillisecondsInLastCall);

                applicant = await new ApplicantGetRequest(applicant.Email, "asdf").LoadResultAsync(client);
                Console.WriteLine("Applicant '{0}' loaded by credentials, {1} ms.",
                    applicant.FirstName + " " + applicant.LastName, client.ElapsedMillisecondsInLastCall);

                try
                {
                    applicant =
                        await
                            new ApplicantGetRequest(applicant.Id, "STZVJj41PGcGIsFxpHfQvxtRCtoAjG").LoadResultAsync(
                                client);
                    Console.WriteLine("Applicant '{0}' loaded by logon token, {1} ms.",
                        applicant.FirstName + " " + applicant.LastName, client.ElapsedMillisecondsInLastCall);
                }
                catch
                {
                    Console.WriteLine("Unable to load applicant by logon token, {0} ms.",
                        client.ElapsedMillisecondsInLastCall);
                }

                /*
                await new ApplicantDeleteRequest(applicant.Id).LoadResultAsync(client);
                Console.WriteLine("Applicant '{0}' anonymized, {1} ms.", applicant.FirstName + " " + applicant.LastName,
                    client.ElapsedMillisecondsInLastCall);
                */
            }
        }

    }
}
