using eRecruiter.Api.Client;
using eRecruiter.Api.Client.Requests;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace eRecruiter.Api.CommandLineClient
{
    public static class JobRequests
    {
        public static async Task Run(ApiHttpClient client)
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

    }
}
