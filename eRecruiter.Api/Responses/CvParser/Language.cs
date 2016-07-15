namespace eRecruiter.Api.Responses
{
    /// <summary>
    /// Description of skills of a language
    /// </summary>
    public class Language
    {
        /// <summary>
        /// Language code
        /// </summary>
        public string LanguageCode { get; set; }

        /// <summary>
        /// Language name
        /// </summary>
        public string LanguageName { get; set; }

        /// <summary>
        /// Langauge level
        /// </summary>
        public string Level { get; set; }
    }
}