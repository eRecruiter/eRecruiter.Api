using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    /// <summary>
    /// Represents a job profile with a name and it's group.
    /// </summary>
    public class JobProfileResponse
    {
        /// <summary>
        /// The name of the job profile.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The name of the group, where the job profile belongs to.
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// The list of cultures, where the job profile should be visible.
        /// </summary>
        public IEnumerable<string> CultureFilter { get; set; }
    }
}
