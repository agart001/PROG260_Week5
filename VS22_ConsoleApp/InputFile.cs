using PROG260_Week5.Interfaces;

namespace VS22_ConsoleApp
{
    public class InputFile : IFile
    {
        public string Path { get; set; }
        public string Dir { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }

        public char Delimiter { get; set; }

        public Type? SerializationType { get; set; }

        public InputFile()
        {

        }

        public InputFile(string path, string name, string extension)
        {
            Path = path;
            Dir = Path.Substring(0, Path.LastIndexOf('\\'));

            Name = name.Substring(0, name.LastIndexOf('.'));
            Extension = extension;

            
        }
    }
}