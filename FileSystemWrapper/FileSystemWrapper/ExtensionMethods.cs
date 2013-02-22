using System.Linq;

namespace FileSystemWrapper
{
    public static class ExtensionMethods
    {
        /// <summary>
        ///     Gets the files without specified extension.
        /// </summary>
        /// <param name="allFiles">All files.</param>
        /// <param name="extension">The extension.</param>
        /// <returns>System.String[][].</returns>
        public static string[] GetFilesWithoutSpecifiedExtension(this string[] allFiles, string extension)
        {
            return
                allFiles.Where(a => a.Substring(a.Length - extension.Length, extension.Length) != extension).ToArray();
        }
    }
}