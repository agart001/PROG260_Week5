using PROG260_Week5.Interfaces;

using static PROG260_Week5.utility.U_IO;

namespace VS22_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo SampleDir = GetDirectoryInfo($"{UseableBaseDir}\\Samples");

            List<IFile> files = new List<IFile>();

            foreach (FileInfo file in SampleDir.GetFiles())
            {
                files.Add(new InputFile(file.FullName, file.Name, file.Extension, GetFileContents(file.FullName)));
            }
        }
    }
}