namespace PROG260_Week5.FileEngines
{
    /// <summary>
    /// Contains constants related to file operations.
    /// </summary>
    public static class FileConstants
    {
        /// <summary>
        /// Gets the project directory as a DirectoryInfo object.
        /// </summary>
        public static DirectoryInfo ProjectDir = new DirectoryInfo(Directory.GetCurrentDirectory());

        /// <summary>
        /// Dictionary mapping file extensions to their respective delimiters.
        /// </summary>
        public static Dictionary<string, char> DelimiterDict = new Dictionary<string, char>()
        {
            {".csv", ','},   // Comma-separated values
            {".txt", '|'}    // Pipe-delimited values
        };
    }
}