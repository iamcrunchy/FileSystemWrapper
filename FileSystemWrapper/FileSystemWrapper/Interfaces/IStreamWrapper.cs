using System.IO;

namespace FileSystemWrapper.Interfaces
{
    public interface IStreamWrapper
    {
        FileStream OpenFileStream(string name, FileMode mode);
    }
}