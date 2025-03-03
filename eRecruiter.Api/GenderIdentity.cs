using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRecruiter.Api
{
    /// <summary>
    /// Provides values representing a person's gender. 
    /// </summary>
    public enum GenderIdentity
    {
        /// <summary>
        /// The gender is unknown or has a value that is not understood by this client. 
        /// </summary>
        Unknown,
        /// <summary>
        /// The person is male. 
        /// </summary>
        Male,
        /// <summary>
        /// The person is female. 
        /// </summary>
        Female,
        /// <summary>
        /// The person is diverse. 
        /// </summary>
        Diverse,

        Inter,

        Open
    }
}
