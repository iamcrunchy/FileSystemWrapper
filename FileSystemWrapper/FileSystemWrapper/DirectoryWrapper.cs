using System;
using System.Collections.Generic;
using System.IO;
using FileSystemWrapper.Interfaces;

namespace FileSystemWrapper
{
    public class DirectoryWrapper : IDirectoryWrapper
    {
        #region IDirectoryWrapper Members

        /// <summary>
        ///     Gets the files from directory.
        /// </summary>
        /// <param name="directoryPath">The directory path.</param>
        /// <returns>string array representing all the files in the directory</returns>
        public string[] GetFilesFromDirectory(string directoryPath)
        {
            return Directory.GetFiles(directoryPath);
        }

        /// <summary>
        /// Gets the file with specified extention from directory.
        /// </summary>
        /// <param name="directoryPath">The directory path.</param>
        /// <param name="extension">The extension.</param>
        /// <returns>System.String[][].</returns>
        public string[] GetFileWithSpecifiedExtentionFromDirectory(string directoryPath, string extension)
        {
            return Directory.GetFiles(directoryPath, extension);
        }

        /// <summary>
        /// Gets the files from all subdirectories.
        /// </summary>
        /// <param name="directoryPath">The directory path.</param>
        /// <returns>System.String[][].</returns>
        public string[] GetFilesFromAllSubdirectories(string directoryPath)
        {
            return Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories);
        }

        /// <summary>
        /// Gets the files with specific extension from all subdirectories.
        /// </summary>
        /// <param name="directoryPath">The directory path.</param>
        /// <param name="extension">The extension.</param>
        /// <returns>System.String[][].</returns>
        public string[] GetFilesWithSpecificExtensionFromAllSubdirectories(string directoryPath, string extension)
        {
            return Directory.GetFiles(directoryPath, extension, SearchOption.AllDirectories);
        }

        /// <summary>
        ///     Gets the files from directory except those with specified extension.
        /// </summary>
        /// <param name="directoryPath">The directory path.</param>
        /// <param name="extension">The extension.</param>
        /// <returns>System.String[][].</returns>
        public string[] GetFilesFromDirectoryExceptThoseWithSpecifiedExtension(string directoryPath, string extension)
        {
            string[] fileList = Directory.GetFiles(directoryPath);
            return fileList.GetFilesWithoutSpecifiedExtension(extension);
        }

        /// <summary>
        ///     Does the directory exist.
        /// </summary>
        /// <param name="directoryPath">The directory path.</param>
        /// <returns>bool indicating if the directory exists</returns>
        public bool DoesDirectoryExist(string directoryPath)
        {
            return Directory.Exists(directoryPath);
        }


        /// <summary>
        ///     Gets the creation time of a file or directory.
        /// </summary>
        /// <param name="path">System.String: path to the file or directory</param>
        /// <returns>A DateTime representing the creation date and time for the specified file or directory</returns>
        public DateTime GetCreationTime(string path)
        {
            return Directory.GetCreationTime(path);
        }

        /// <summary>
        /// Gets the large collection of files.
        /// </summary>
        /// <param name="directoryPath">The directory path.</param>
        /// <returns>IEnumerable{System.String}.</returns>
        public IEnumerable<string> GetLargeCollectionOfFiles(string directoryPath)
        {
            return Directory.EnumerateFiles(directoryPath);
        }

        #endregion
    }
}