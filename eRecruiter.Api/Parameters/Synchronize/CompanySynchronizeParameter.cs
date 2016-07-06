namespace eRecruiter.Api.Parameters
{
    /// <summary>
    /// Request Body-Parameter
    /// </summary>
    public class CompanySynchronizeParameter
    {
        /// <summary>
        /// Xml content represented as string. Will be validated with the Company-Import Xml-schema.
        /// </summary>
        public string XmlContent { get; set; }
    }
}
