using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRecruiter.Api.Responses.Job
{
    public class Google4JobsLocationResponse
    {
        public string Street { get; set; }
        public string HouseNo { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

    }
}
