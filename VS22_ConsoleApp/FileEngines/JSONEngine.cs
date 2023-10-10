
using PROG260_Week5.Interfaces;
using System.Text.Json;

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
                string jsonstring = reader.ReadToEnd();

                var options = new JsonSerializerOptions
                {
                    PropertyNamingPolicy = null,
                    PropertyNameCaseInsensitive = true
                };

                T obj = JsonSerializer.Deserialize<T>(jsonstring, options);

                using(StreamWriter writer = new StreamWriter(outputfile, true))
                {
                    writer.WriteLine($"Line#1 : {obj}");
                }
            }
            
        }
    }
}