using System.IO;
using FileSystemWrapper.Interfaces;

namespace FileSystemWrapper
{
    public class StreamWrapper : IStreamWrapper 
    {
        /// <summary>
        /// Opens the file stream.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="mode">The mode.</param>
        /// <returns>FileStream</returns>
        public FileStream OpenFileStream(string name, FileMode mode)
        {
            var fs = new FileStream(name, mode);
            return fs;
        }
    }
}