using System;

namespace eRecruiter.Api.Responses
{
    /// <summary>
    /// Describes an education
    /// </summary>
    public class Education
    {
        /// <summary>
        /// Education start date
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Education end date
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Is currently experiencing this Education
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