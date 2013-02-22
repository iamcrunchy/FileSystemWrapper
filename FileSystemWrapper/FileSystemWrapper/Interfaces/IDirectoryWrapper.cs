using System;
using System.Collections.Generic;

namespace FileSystemWrapper.Interfaces
{
	public interface IDirectoryWrapper
	{
        /// <summary>
        /// Gets the files from directory.
        /// </summary>
        /// <param name="directoryPath">The directory path.</param>
        /// <returns>System.String[][].</returns>
		string[] GetFilesFromDirectory(string directoryPath);

        /// <summary>
        /// Gets the file with specified extention from directory.
        /// </summary>
        /// <param name="directoryPath">The directory path.</param>
        /// <param name="extension">The extension.</param>
        /// <returns>System.String[][].</returns>
	    string[] GetFileWithSpecifiedExtentionFromDirectory(string directoryPath, string extension);

        /// <summary>
        /// Gets the files from all subdirectories.
        /// </summary>
        /// <param name="directoryPath">The directory path.</param>
        /// <returns>System.String[][].</returns>
	    string[] GetFilesFromAllSubdirectories(string directoryPath);

        /// <summary>
        /// Gets the files with specific extension from all subdirectories.
        /// </summary>
        /// <param name="directoryPath">The directory path.</param>
        /// <param name="extension">The extension.</param>
        /// <returns>System.String[][].</returns>
	    string[] GetFilesWithSpecificExtensionFromAllSubdirectories(string directoryPath, string extension);

        /// <summary>
        /// Gets the files from directory except those with specified extension.
        /// </summary>
        /// <param name="directoryPath">The directory path.</param>
        /// <param name="extension">The extension.</param>
        /// <returns>System.String[][].</returns>
	    string[] GetFilesFromDirectoryExceptThoseWithSpecifiedExtension(string directoryPath, string extension);

        /// <summary>
        /// Doeses the directory exist.
        /// </summary>
        /// <param name="directoryPath">The directory path.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
	    bool DoesDirectoryExist(string directoryPath);


        /// <summary>
        /// Gets the creation time
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>DateTime.</returns>
	    DateTime GetCreationTime(string path);

        /// <summary>
        /// Gets a large collection of files.
        /// <para>Use this method with expecting a large collection of files. For most uses GetFilesFromDirectory 
        /// should be used.</para>
        /// </summary>
        /// <param name="directoryPath">The directory path.</param>
        /// <returns>IEnumerable{System.String}.</returns>
	    IEnumerable<string> GetLargeCollectionOfFiles(string directoryPath);
	}
}
