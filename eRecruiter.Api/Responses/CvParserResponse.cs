using System;

namespace eRecruiter.Api.Responses
{
    public class CvParserResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }

        public string TitleBeforeName { get; set; }
        public string TitleAfterName { get; set; }

        public DateTime? BirthDate { get; set; }

        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string Citizenship { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }

        public byte[] Photo { get; set; }
    }
}
