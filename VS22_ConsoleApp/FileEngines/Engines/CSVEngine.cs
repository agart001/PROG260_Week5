
using PROG260_Week5.Interfaces;
using static PROG260_Week5.FileEngines.FileConstants;

namespace PROG260_Week5.FileEngines.Engines
{
    /// <summary>
    /// Represents a CSV file processing engine, extending the FileEngine base class.
    /// </summary>
    public class CSVEngine : FileEngine
    {
        /// <summary>
        /// Overrides the base class method to implement CSV file processing logic.
        /// </summary>
        /// <param name="file">The CSV file to be processed.</param>
        public override void Process(IFile file)
        {
            // Clear any existing output file associated with the input file
            ClearOutputFile(file);

            // Create a new output file for writing the processed content
            FileStream stream = new FileStream($"{file.Dir}\\{file.Name}_.out.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            // Open the input file for reading
            using (StreamReader reader = new StreamReader(file.Path))
            {
                int lineCount = 1;
                var line = reader.ReadLine();

                // Process each line of the CSV file
                while (line != null)
                {
                    // Initialize the output string with the line number
                    string output = $"Line #{lineCount}: ";
                    var fields = line.Split(DelimiterDict[file.Extension]);

                    int fieldCount = 1;

                    // Process each field in the line
                    foreach (var field in fields)
                    {
                        // Add field information to the output string
                        if (fieldCount != 1) output += " ==> ";
                        output += $"Field #{fieldCount}={field}";
                        fieldCount++;
                    }

                    // Write the processed line to the output file
                    writer.WriteLine(output);

                    lineCount++;
                    line = reader.ReadLine();
                }
            }

            // Close the writer and stream to release resources
            writer.Close();
            stream.Close();
        }
    }
}
