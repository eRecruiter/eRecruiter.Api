using System;
using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class CompanySynchronizeResponse
    {
        public StatusType Status;
        public SyncResult Result { get; set; }
    }

    [Flags]
    public enum StatusType
    {
        ValidData = 1,
        InValidData = 2,
        PeristingSkiped = 4,
        PersistingError = 8,
        PersistingSuccess = 16
        // = 32
        // = 64
        // = ...
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
