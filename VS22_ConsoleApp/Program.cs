using PROG260_Week5.FileEngines;
using PROG260_Week5.Interfaces;
using PROG260_Week5.SampleJSON;

namespace VS22_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo SampleDir = new DirectoryInfo($"{Directory.GetCurrentDirectory()}\\samples");

            List<IFile> files = new List<IFile>();

            foreach (FileInfo file in SampleDir.GetFiles())
            {
                files.Add(new InputFile(file.FullName, file.Name, file.Extension));
            }


            files = files.Where(file => file.Extension == ".json").ToList();
            

            foreach(IFile file in files)
            {
                FileEngine engine;

                switch(file.Extension)
                {
                    case ".txt": 
                        engine = new TXTEngine();
                        engine.Process(file);
                    break;
                    case ".csv": 
                        engine = new CSVEngine();
                        engine.Process(file);
                    break;
                    case ".xml": 
                        engine = new XMLEngine();
                        engine.Process(file);
                    break;
                    case ".json": 
                        engine = new JSONEngine();
                        engine.Process<Student>(file);
                    break;
                }
            }
        }
    }
}