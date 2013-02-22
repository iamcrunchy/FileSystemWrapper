using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileSystemWrapper.Interfaces
{
    public interface IFileWrapper
    {
        bool FileExists(string path);
        bool AppendAllLinesToFile(string path, IEnumerable<string> lines);
        bool AppendAllLinesToFile(string path, IEnumerable<string> lines, Encoding encoding);
        bool AppendAllTextToFile(string path, string textToAppend);
        bool AppendAllTextToFile(string path, string textToAppend, Encoding encoding);
        bool AppendTextToFile(string path);
        bool CopyFile(string source, string destination);
        bool CopyFile(string source, string destination, bool overwrite);
        bool FileCreate(string path);
        bool DeleteFile(string path);
        bool MoveFile(string source, string destination);
        FileAttributes GetFileAttributes(string path);
        DateTime GetTimeLastAccessed(string path);
    }
}