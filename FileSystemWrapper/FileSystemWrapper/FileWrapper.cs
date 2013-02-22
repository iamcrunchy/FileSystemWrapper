using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using FileSystemWrapper.Interfaces;

namespace FileSystemWrapper
{
    public class FileWrapper : IFileWrapper
    {
        #region System.IO wrapper methods

        #region Exists

        /// <summary>
        /// If the specified in the path exists return true
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>bool indicating if the file exists</returns>
        public bool FileExists(string path)
        {
            if (File.Exists(path))
                return true;
            return false;
        }

        #endregion

        #region Copy    

        /// <summary>
        /// Copies the file from the source location to the destination location
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="destination">The destination.</param>
        /// <returns></returns>
        public bool CopyFile(string source, string destination)
        {
            File.Copy(source, destination);
            return true;
        }

        /// <summary>
        /// Copies the file from the source location to the destination location
        /// If a file of the same name already exists in the detination it will be over if overwrite = true
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="destination">The destination.</param>
        /// <param name="overwrite">if set to <c>true</c> [overwrite].</param>
        /// <returns></returns>
        public bool CopyFile(string source, string destination, bool overwrite)
        {
            File.Copy(source, destination, overwrite);
            return true;
        }


        #endregion

        #region Move

        /// <summary>
        /// Moves the file fro the source location to the destination location
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="destination">The destination.</param>
        /// <returns></returns>
        public bool MoveFile(string source, string destination)
        {
            File.Move(source, destination);
            return true;
        }


        #endregion

        #region Append

        /// <summary>
        /// Appends all lines in the enumerable to  the specified file
        /// When the lines have been appended the file is closed.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="lines">The lines.</param>
        /// <returns></returns>
        public bool AppendAllLinesToFile(string path, IEnumerable<string> lines)
        {
            File.AppendAllLines(path, lines);
            return true;
        }

        /// <summary>
        /// Appends all lines in the enumerable to  the specified file with the specified encoding
        /// When the lines have been appended the file is closed.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="lines">The lines.</param>
        /// <param name="encoding">The encoding.</param>
        /// <returns></returns>
        public bool AppendAllLinesToFile(string path, IEnumerable<string> lines, Encoding encoding)
        {
            File.AppendAllLines(path, lines, encoding);
            return true;
        }

        /// <summary>
        /// Appends all text to to  the specified file 
        /// When the test has been appended the file is closed.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="textToAppend">The text to append.</param>
        /// <returns></returns>
        public bool AppendAllTextToFile(string path, string textToAppend)
        {
            File.AppendAllText(path, textToAppend);
            return true;
        }

        /// <summary>
        /// Opens a file, or if the file does not exist create it
        /// Appends all text to to  the specified file with the specified encoding
        /// When the test has been appended the file is closed.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="textToAppend">The text to append.</param>
        /// <param name="encoding">The encoding.</param>
        /// <returns></returns>
        public bool AppendAllTextToFile(string path, string textToAppend, Encoding encoding)
        {
            File.AppendAllText(path, textToAppend, encoding);
            return true;
        }

        /// <summary>
        /// Appends the text to file by creating a StreamWriter that appends UTF-8 encoded text 
        /// to an existing file
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public bool AppendTextToFile(string path)
        {
            File.AppendText(path);
            return true;
        }

        #endregion

        #region Delete

        /// <summary>
        /// Deletes the file.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public bool DeleteFile(string path)
        {
            File.Delete(path);
            return true;
        }

        #endregion

        #region Create

        /// <summary>
        /// Creates the file.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        public bool FileCreate(string path)
        {
            File.Create(path);
            return true;
        }

        #endregion

        #region Attributes

        /// <summary>
        /// Gets the file attributes.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>FileAttributes.</returns>
        public FileAttributes GetFileAttributes(string path)
        {
            return File.GetAttributes(path);
        }

        /// <summary>
        /// Gets the time last accessed.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>DateTime.</returns>
        public DateTime GetTimeLastAccessed(string path)
        {
            return File.GetLastAccessTime(path);
        }

        #endregion

        #endregion
    }
}