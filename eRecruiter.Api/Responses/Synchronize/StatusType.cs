using System;

namespace eRecruiter.Api.Responses
{
    [Flags]
    public enum StatusType
    {
        ValidData = 1 << 0,
        InvalidData = 1 << 1,
        PersistingSkipped = 1 << 2,
        PersistingError = 1 << 3,
        PersistingSuccess = 1 << 4
    }
}