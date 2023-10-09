
using System.Xml.Serialization;
using PROG260_Week5.Interfaces;
using PROG260_Week5.SampleXML;

namespace PROG260_Week5.FileEngines
{
    public class XMLEngine : FileEngine
    {
        public override void Process(IFile file)
        {
            ClearOutputFile(file);

            using(FileStream stream = File.Open(file.Path, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Grocery));
                var grocery = (Grocery)serializer.Deserialize(stream);

                int lineCount = 1;
                using(StreamWriter writer =  new StreamWriter($"{file.Name}_out.txt", true))
                {
                    foreach(var item in grocery.Inventory)
                    {
                        writer.WriteLine($"Line #{lineCount}: {item}");
                        lineCount++;
                    }
                }
            }
        }

    }
}