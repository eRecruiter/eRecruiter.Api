namespace eRecruiter.Api.Parameters
{
    /// <summary>
    /// Request Body-Parameter
    /// </summary>
    public class CompanySynchronizeParameter
    {
        /// <summary>
        /// Xml content represented as string. Will be validated against Company-Import schema.
        /// </summary>
        public string XmlContent { get; set; }
    }
}
