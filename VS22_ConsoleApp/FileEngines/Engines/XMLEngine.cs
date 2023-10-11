
using System.Xml.Serialization;
using PROG260_Week5.Interfaces;
using PROG260_Week5.SampleXML;

namespace PROG260_Week5.FileEngines.Engines
{
    /// <summary>
    /// Represents an XML file processing engine, extending the FileEngine base class. Currently only functions the Grocery class.
    /// </summary>
    public class XMLEngine : FileEngine
    {
        /// <summary>
        /// Overrides the base class method to implement XML file processing logic.
        /// </summary>
        /// <param name="file">The XML file to be processed.</param>
        public override void Process(IFile file)
        {
            // Clear any existing output file associated with the input file
            ClearOutputFile(file);

            // Open the input file for reading
            using (FileStream stream = File.Open(file.Path, FileMode.Open))
            {
                // Create an XML serializer for the specified type (Grocery in this case)
                XmlSerializer serializer = new XmlSerializer(typeof(Grocery));

                // Deserialize the XML content into a Grocery object
                var grocery = (Grocery)serializer?.Deserialize(stream);

                // Check if deserialization was successful
                if (grocery == null)
                {
                    // If deserialization failed, return without writing to the output file
                    return;
                }

                // Open the output file for writing
                using (StreamWriter writer = new StreamWriter($"{file.Dir}\\{file.Name}_out.txt", true))
                {
                    // Iterate through each item in the Grocery and write to the output file
                    int lineCount = 1;
                    foreach (var item in grocery.Item)
                    {
                        writer.WriteLine($"Line #{lineCount}: {item}");
                        lineCount++;
                    }
                }
            }
        }
    }
}