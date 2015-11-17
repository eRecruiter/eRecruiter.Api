using System;

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
    }
}
