using System;
using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    /// <summary>
    /// The parser result with information about the person desribed in the uploaded Cv.
    /// </summary>
    public class CvParserResponse
    {
        /// <summary>
        /// The first name of the person.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The surname of the person.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The gender of the person.
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// The academic title, which usually is written before a person's name.
        /// </summary>
        public string TitleBeforeName { get; set; }

        /// <summary>
        /// The academic degree, which usually is written after a person's name.
        /// </summary>
        public string TitleAfterName { get; set; }

        /// <summary>
        /// The date of birth.
        /// </summary>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The street of the person's address.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// The city of the person's address.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The ZIP (Zone Improvement Plan) code of the person's address.
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// The country of the person's address.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// The citizenship of the person.
        /// </summary>
        public string Citizenship { get; set; }

        /// <summary>
        /// The email address of the person.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The telephone number of the person.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// The photo of the person. The type of the image is JPG.
        /// </summary>
        public byte[] Photo { get; set; }

        /// <summary>
        /// Additional information if available.
        /// </summary>
        public string Summary { get; set; }
        
        /// <summary>
        /// Competences of the person.
        /// </summary>
        public IEnumerable<string> Competences { get; set; }

        /// <summary>
        /// Interests of the person.
        /// </summary>
        public IEnumerable<string> Interests { get; set; }

        /// <summary>
        /// URL's found in the document.
        /// </summary>
        public IEnumerable<string> Urls { get; set; }

        /// <summary>
        /// Skills of the person.
        /// </summary>
        public IEnumerable<SkillResponse> Skills { get; set; }

        /// <summary>
        /// Work experiences of the person.
        /// </summary>
        public IEnumerable<ExperienceResponse> Experiences { get; set; }

        /// <summary>
        /// Educations of the person.
        /// </summary>
        public IEnumerable<EducationResponse> Educations { get; set; }

        /// <summary>
        /// Certifications of the person.
        /// </summary>
        public IEnumerable<CertificationResponse> Certifications { get; set; }

        /// <summary>
        /// Language skills of the person.
        /// </summary>
        public IEnumerable<LanguageResponse> Languages { get; set; }

        /// <summary>
        /// Publications of the person.
        /// </summary>
        public IEnumerable<PublicationResponse> Publications { get; set; }
    }
}