﻿namespace eRecruiter.Api.Parameters
{
    public class JobTextParameter
    {
        public string Culture { get; set; }
        public int TemplateId { get; set; }
        public int? QuestionnaireId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Location { get; set; }
        public SocialMediaParameter SocialMedia { get; set; }
        public string Introduction { get; set; }
        public string Description { get; set; }
        public string Requirements { get; set; }
        public string Offer { get; set; }
        public string InternalInformation { get; set; }
    }
}
