using PROG260_Week5.FileEngines.Engines;
using PROG260_Week5.Interfaces;
using PROG260_Week5.SampleJSON;
using VS22_ConsoleApp.FileEngines;

using static PROG260_Week5.FileEngines.FileConstants;

namespace PROG260_Week5.FileEngines
{
    /// <summary>
    /// A utility class for processing various types of files using specialized file engines.
    /// </summary>
    public static class FEngine
    {
        /// <summary>
        /// The currently selected file processing engine.
        /// </summary>
        private static FileEngine Engine { get; set; }

        /// <summary>
        /// Processes a list of files using the appropriate file engine based on file extensions.
        /// </summary>
        /// <param name="files">The list of files to be processed.</param>
        public static void ProcessFiles(List<IFile> files)
        {
            foreach (IFile file in files)
            {
                switch (file.Extension)
                {
                    case ".txt":
                        Engine = new TXTEngine();
                        Engine.Process(file);
                        break;
                    case ".csv":
                        Engine = new CSVEngine();
                        Engine.Process(file);
                        break;
                    case ".xml":
                        Engine = new XMLEngine();
                        Engine.Process(file);
                        break;
                    case ".json":
                        Engine = new JSONEngine();
                        Engine.Process<Student>(file);
                        break;
                }
            }
        }

        /// <summary>
        /// Reads files from a specified directory and returns a list of IFile objects.
        /// </summary>
        /// <param name="dir">The directory from which to read files.</param>
        /// <returns>A list of IFile objects representing the files in the specified directory.</returns>
        public static List<IFile> ReadFiles(string dir)
        {
            // Create a DirectoryInfo object for the specified directory
            DirectoryInfo Dir = new DirectoryInfo($"{ProjectDir}\\{dir}");

            // Create a list to store IFile objects representing files in the directory
            List<IFile> files = new List<IFile>();

            // Iterate through each file in the directory and add it to the list
            foreach (FileInfo file in Dir.GetFiles())
            {
                files.Add(new InputFile(file.FullName, file.Name, file.Extension));
            }

            // Return the list of files
            return files;
        }
    }
}