using System.IO;
using FileSystemWrapper.Interfaces;

namespace FileSystemWrapper
{
    public class FileInfoWrapper : IFileInfoWrapper
    {
        #region IFileInfoWrapper Members

        /// <summary>
        /// Gets the size of the specified file in bytes.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public long GetFileSize(string filePath)
        {
            var fi = new FileInfo(filePath);
            return fi.Length;
        }

        #endregion
    }
}