
using PROG260_Week5.Interfaces;
using Newtonsoft.Json;

namespace PROG260_Week5.FileEngines.Engines
{
    /// <summary>
    /// Represents a JSON file processing engine, extending the FileEngine base class.
    /// </summary>
    public class JSONEngine : FileEngine
    {
        /// <summary>
        /// Overrides the base class method to implement JSON file processing logic.
        /// </summary>
        /// <typeparam name="T">The type of object to deserialize the JSON content into.</typeparam>
        /// <param name="file">The JSON file to be processed.</param>
        public override void Process<T>(IFile file)
        {
            // Clear any existing output file associated with the input file
            ClearOutputFile(file);

            // Construct the path for the output file
            string outputfile = $"{file.Dir}\\{file.Name}_.out.txt";

            // Open the input file for reading
            using (StreamReader reader = new StreamReader(file.Path))
            {
                // Deserialize the JSON content into an object of type T
                T obj = JsonConvert.DeserializeObject<T>(reader.ReadToEnd());

                // Check if deserialization was successful
                if (obj == null)
                {
                    // If deserialization failed, return without writing to the output file
                    return;
                }

                // Open the output file for writing
                using (StreamWriter writer = new StreamWriter(outputfile, true))
                {
                    // Write the deserialized object to the output file
                    writer.WriteLine($"Line#1 : {obj}");
                }
            }
        }
    }
}