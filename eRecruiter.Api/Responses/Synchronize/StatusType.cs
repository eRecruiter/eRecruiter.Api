using System;

namespace eRecruiter.Api.Responses
{
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
}