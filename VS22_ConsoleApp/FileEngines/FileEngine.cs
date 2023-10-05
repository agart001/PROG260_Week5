using PROG260_Week5.Interfaces;

namespace PROG260_Week5.FileEngines
{
    public abstract class FileEngine
    {
        public virtual void Process(IFile file)
        {
            throw new NotImplementedException();
        }

        public virtual void Process<T>(IFile file)
        {
            throw new NotImplementedException();
        }

        public void ClearOutputFile(IFile file)
        {
            string output = $"{file.Dir}\\{file.Name}_.out.txt";
            if(File.Exists(output) == false) return;

            File.Delete(output);
        }
    }
}