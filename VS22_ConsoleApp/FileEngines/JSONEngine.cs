
using PROG260_Week5.Interfaces;
using Newtonsoft.Json;
using Microsoft.Win32.SafeHandles;

namespace PROG260_Week5.FileEngines
{
    public class JSONEngine : FileEngine
    {
        public override void Process<T>(IFile file)
        {
            ClearOutputFile(file);

            string outputfile = $"{file.Dir}\\{file.Name}_.out.txt";
            using(StreamReader reader = new StreamReader(file.Path))
            {
                T obj = JsonConvert.DeserializeObject<T>(reader.ReadToEnd());

                if(obj == null) {return;}

                using(StreamWriter writer = new StreamWriter(outputfile, true))
                {
                    writer.WriteLine($"Line#1 : {obj}");
                }
            }
            
        }
    }
}