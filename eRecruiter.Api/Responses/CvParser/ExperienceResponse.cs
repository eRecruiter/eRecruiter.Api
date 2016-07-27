using System;

namespace eRecruiter.Api.Responses
{
    /// <summary>
    /// Description of an experience
    /// </summary>
    public class ExperienceResponse
    {
        /// <summary>
        /// Experience start date
        /// </summary>
        public FlexDate StartDate { get; set; }

        /// <summary>
        /// Experience end date
        /// </summary>
        public FlexDate EndDate { get; set; }

        /// <summary>
        /// Is current workplace
        /// </summary>
        public bool IsCurrent { get; set; }

        /// <summary>
        /// Company name
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Business type
        /// </summary>
        public string Industry { get; set; }

        /// <summary>
        /// Position in company
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Function in company
        /// </summary>
        public string Function { get; set; }

        /// <summary>
        /// Descripton
        /// </summary>
        public string Description { get; set; }
    }
}