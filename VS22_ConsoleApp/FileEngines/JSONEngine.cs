
using PROG260_Week5.Interface

namespace PROG260_Week5.FileEngines
{
    public class JSONEngine : FileEngine
    {
        public override void Process<T>(IFile file)
        {
            using(StreamReader reader = new StreamReader(file.Path))
            {
                T obj = JsonConvert.DeserializeObject<T>(reader.ReadToEnd());
            }
        }
    }
}