using PROG260_Week5.Interfaces;

namespace VS22_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo SampleDir = new DirectoryInfo($"{Directory.GetCurrentDirectory}\\samples");

            List<IFile> files = new List<IFile>();

            foreach (FileInfo file in SampleDir.GetFiles())
            {
                files.Add(new InputFile(file.FullName, file.Name, file.Extension));
            }
        }
    }
}