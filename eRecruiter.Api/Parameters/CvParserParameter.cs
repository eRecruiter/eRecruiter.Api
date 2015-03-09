namespace eRecruiter.Api.Parameters
{
    /// <summary>
    /// Wraps the file information of the Cv to parse.
    /// </summary>
    public class CvParserParameter
    {
        /// <summary>
        /// The filename of the curriculum vitae.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// The file content of the Cv as byte array.
        /// </summary>
        public byte[] Content { get; set; }
    }
}
