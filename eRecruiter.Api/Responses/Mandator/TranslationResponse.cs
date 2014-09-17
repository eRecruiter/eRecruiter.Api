using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class TranslationResponse
    {
        public string Key { get; set; }
        public IEnumerable<TranslationTextResponse> Texts { get; set; }
    }
}