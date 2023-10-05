using static PROG260_Week5.utility.U_IO;

namespace PROG260_Week5
{
    public class InputFile : IFile
    {
        public string AbsPath { get; set; }
        public string Dir { get; set; }

        public string Name { get; set; }
        public string Extension { get; set; }
        public char Delimiter { get; set; }

        public string FileContents { get; set; }


        public InputFile()
        {

        }

        public InputFile(string absPath, string name, string extension, string fileContents)
        {
            AbsPath = absPath;
            Dir = AbsPath.Substring(0, AbsPath.LastIndexOf('\\'));

            Name = name.Substring(0, name.LastIndexOf('.'));
            Extension = extension;
            Delimiter = DelimiterDict[Extension];

            FileContents = fileContents;
        }
    }
}