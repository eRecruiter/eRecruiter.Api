using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class CompanyImportResponse
    {
        public SyncResult Result { get; set; }
    }

    public class SyncResult
    {
        public string Identifiyer { get; set; }
        public string Type { get; set; }
        public IEnumerable<Message> Messages { get; set; }
        public IEnumerable<SyncResult> NestedResults { get; set; }
    }

    public class Message
    {
        public string Text { get; set; }
        public Severity Severity { get; set; }
    }

    public enum Severity
    {
        Trace,
        Debug,
        Info,
        Warning,
        Error
    }
}
