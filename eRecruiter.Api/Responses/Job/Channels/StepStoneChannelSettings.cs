using System.Collections.Generic;

namespace eRecruiter.Api.Responses.Job.Channels
{
    public class StepStoneChannelSettings
    {
        public IList<string> Headers { get; set; }
        public string Background { get; set; }
        public string Video { get; set; }
        public string Contact { get; set; }
    }
}
