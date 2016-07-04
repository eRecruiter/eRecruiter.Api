using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class SyncResult
    {
        public string Identifyer { get; set; }
        public string Type { get; set; }
        public IEnumerable<Message> Messages { get; set; }
        public IEnumerable<SyncResult> NestedResults { get; set; }
    }
}