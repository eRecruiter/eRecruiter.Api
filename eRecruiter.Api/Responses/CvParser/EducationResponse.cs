using System;

namespace eRecruiter.Api.Responses
{
    /// <summary>
    /// Describes an education
    /// </summary>
    public class EducationResponse
    {
        /// <summary>
        /// Education start date
        /// </summary>
        public FlexDate StartDate { get; set; }

        /// <summary>
        /// Education end date
        /// </summary>
        public FlexDate EndDate { get; set; }

        /// <summary>
        /// Is currently studying this field of education
        /// </summary>
        public bool IsCurrent { get; set; }

        /// <summary>
        /// Country of the education
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// School name of the ecucation
        /// </summary>
        public string School { get; set; }

        /// <summary>
        /// Filed of study
        /// </summary>
        public string FieldOfStudy { get; set; }

        /// <summary>
        /// International Standard Classification of Education code
        /// </summary>
        public string IscedCode { get; set; }
        
        /// <summary>
        /// Degree of the education
        /// </summary>
        public string Degree { get; set; }
    }
}