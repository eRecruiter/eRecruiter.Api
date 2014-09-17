using eRecruiter.Api.Responses;
using System.Net.Http;

namespace eRecruiter.Api.Client.Requests
{
    public class JobSalaryImageRequest : HttpRequestMessage<JobSalaryImageResponse>
    {
        public JobSalaryImageRequest(int jobId)
            : base(HttpMethod.Get, "Api/Job/SalaryImage/" + jobId)
        {
        }
    }
}
