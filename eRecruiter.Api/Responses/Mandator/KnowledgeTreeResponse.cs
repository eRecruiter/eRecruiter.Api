using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class KnowledgeTreeResponse
    {
        public IEnumerable<KnowledgeTreeJobProfile> JobProfiles { get; set; }
    }

    public class KnowledgeTreeJobProfile
    {
        public string JobProfile { get; set; }
        public IEnumerable<KnowledgeTreeGroup> Groups { get; set; }
    }

    public class KnowledgeTreeGroup
    {
        public string Group { get; set; }
        public IEnumerable<string> Knowledges { get; set; }
    }
}
