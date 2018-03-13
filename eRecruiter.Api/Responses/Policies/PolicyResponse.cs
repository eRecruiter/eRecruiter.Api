using System;
using eRecruiter.Api.Responses.Policies;

namespace eRecruiter.Api.Responses
{
    public class PolicyResponse
    {
        /// <summary>
        /// The unique identifier of the policy.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The policy text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Date of creation
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Type of the policy
        /// </summary>
        public PolicyType Type { get; set; }

    }
}
