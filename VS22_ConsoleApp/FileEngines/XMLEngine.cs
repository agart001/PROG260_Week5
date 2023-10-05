
using System.Xml.Serialization;
using PROG260_Week5.Interfaces;

namespace PROG260_Week5.FileEngines
{
    public class XMLEngine : FileEngine
    {
        public override void Process<T>(IFile file)
        {
            ClearOutputFile(file);

            using(FileStream stream = File.Open(file.Path, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                var objects = (T)serializer.Deserialize(stream);

                if(objects == null) return;

                int lineCount = 1;
                using(StreamWriter writer =  new StreamWriter($"{file.Name}_out.txt", true))
                {
                    foreach (var obj in objects)
                    {
                        writer.WriteLine($"Line #{lineCount}: {obj.ToString()}");
                        lineCount++;
                    }
                }
            }
        }

    }
}