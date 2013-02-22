using System.IO;
using System.Web;
using FileSystemWrapper.Interfaces;

namespace FileSystemWrapper
{
    public class PathWrapper : IPathWrapper
    {
        #region IPathWrapper Members

        /// <summary>
        /// Gets the absolute path.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>the absolute path to the specified files</returns>
        public string GetAbsolutePath(string path)
        {
            return Path.GetFullPath(path);
        }

        /// <summary>
        /// Gets the name of the file.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>string representing the name of the file specified in the path</returns>
        public string GetFileName(string path)
        {
            return Path.GetFileName(path);
        }

        /// <summary>
        /// Gets the file name without extension.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>string representing the name of the file specified in the path</returns>
        public string GetFileNameWithoutExtension(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        /// <summary>
        /// Gets the path to a file, or folder, on the server.
        /// <para>This method is for use only on web projects.</para>
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public string GetServerMappedPath(string path)
        {
            return HttpContext.Current.Server.MapPath(path);
        }

        /// <summary>
        /// Combines the first string with the second string to produce a path.
        /// </summary>
        /// <param name="first">The first.</param>
        /// <param name="second">The second.</param>
        /// <returns>string reprenting a path</returns>
        public string CombinePath(string first, string second)
        {
            return Path.Combine(first, second);
        }

	    #endregion
	}
}
