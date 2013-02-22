namespace FileSystemWrapper.Interfaces
{
	public interface IPathWrapper
	{
		string GetAbsolutePath(string path);
	    string GetFileName(string path);
	    string GetFileNameWithoutExtension(string path);
	    string GetServerMappedPath(string path);
	    string CombinePath(string first, string second);
	}
}