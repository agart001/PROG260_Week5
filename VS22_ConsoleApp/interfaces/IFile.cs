namespace PROG260_Week5.Interfaces
{
    public interface IFile
    {
        public string Path { get; set; }
        public string Dir { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
    }
}