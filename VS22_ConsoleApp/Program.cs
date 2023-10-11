using static PROG260_Week5.FileEngines.FEngine;
using PROG260_Week5.Interfaces;

/// <summary>
/// 
/// All comments were generated using ChatGPT3 
/// using a text document to as shell to copy paste.
/// I used to following format when generating them:
/// 
/// generate code clarity comments for this c# { --- }:
///     
///     -
///     -
///     -
///     
/// 
/// ChatGPT3 url: https://openai.com/
/// 
/// I also used the code sample from the PROG260_Week5.pptm
/// to create the overrall Engine structure and the XML/JSON Engines.
/// 
/// </summary>

namespace VS22_ConsoleApp
{
    // Define the main program class
    internal class Program
    {
        // The main entry point of the application
        static void Main(string[] args)
        {
            // Read files from the "Samples" directory
            List<IFile> files = ReadFiles("Samples");

            // Process the read files using the file processing engine
            ProcessFiles(files);
        }
    }
}
