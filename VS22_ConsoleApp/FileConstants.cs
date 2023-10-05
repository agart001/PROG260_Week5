namespace PROG260_Week5
{
    public static class FileConstants
    {
        public static DirectoryInfo ProjectDir = new DirectoryInfo(Directory.GetCurrentDirectory());
        public static Dictionary<string, char> DelimiterDict = new Dictionary<string, char>()
        {
            {".csv", ','},
            {".txt", '|'}
        };
    }
}