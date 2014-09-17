using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class QuestionnaireResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public QuestionnaireLocation Location { get; set; }

        public IEnumerable<QuestionnaireItemResponse> Items { get; set; }

        public enum QuestionnaireLocation
        {
            OnFirstPage,
            OnSecondPage
        }
    }
}
