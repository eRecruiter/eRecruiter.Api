namespace eRecruiter.Api.Responses
{
    public class GeoLocationResponse
    {
        public string type { get; set; }
        public double[] coordinates { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string City { get; set; }
    }
}
