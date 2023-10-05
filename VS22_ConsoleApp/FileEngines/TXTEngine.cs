using PROG260_Week5.Interfaces;
using static PROG260_Week5.FileConstants;

namespace PROG260_Week5.FileEngines
{
    public class TXTEngine : FileEngine
    {
        public override void Process(IFile file)
        {
            ClearOutputFile(file);

            FileStream stream = new FileStream($"{file.Dir}\\{file.Name}_.out.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            using (StreamReader reader = new StreamReader(file.Path))
            {
                int lineCount = 1;
                var line = reader.ReadLine();

                while(line != null)
                {
                    string output = $"Line #{lineCount}: ";
                    var fields = line.Split(DelimiterDict[file.Extension]);

                    int fieldCount = 1;
                    foreach (var field in fields)
                    {
                        if(fieldCount != 1) output += " ==> ";
                        output += $"Field #{fieldCount}={field}";
                        fieldCount++;
                    }

                    writer.WriteLine(output);

                    lineCount++;
                    line = reader.ReadLine();
                }
            }

            writer.Close();
            stream.Close();
        }
    }
}