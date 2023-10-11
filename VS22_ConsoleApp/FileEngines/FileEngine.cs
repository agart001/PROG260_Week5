using PROG260_Week5.Interfaces;

namespace PROG260_Week5.FileEngines
{
    /// <summary>
    /// An abstract class representing a generic file processing engine.
    /// </summary>
    public abstract class FileEngine
    {
        /// <summary>
        /// Processes the input file using the default processing logic.
        /// Subclasses should override this method to provide specific processing logic.
        /// </summary>
        /// <param name="file">The input file to be processed.</param>
        public virtual void Process(IFile file)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Generic method for processing the input file with a specified type parameter.
        /// Subclasses can provide additional processing logic based on the generic type.
        /// </summary>
        /// <typeparam name="T">The type parameter.</typeparam>
        /// <param name="file">The input file to be processed.</param>
        public virtual void Process<T>(IFile file)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Clears the output file associated with the input file.
        /// </summary>
        /// <param name="file">The input file for which the associated output file will be cleared.</param>
        public void ClearOutputFile(IFile file)
        {
            // Construct the path for the output file
            string output = $"{file.Dir}\\{file.Name}_.out.txt";

            // Check if the output file exists before attempting to delete it
            if (File.Exists(output) == false)
                return;

            // Delete the output file
            File.Delete(output);
        }
    }
}