namespace System.IO.Extensions
{
	public interface IFileInfo
	{
		string Name { get; }
		long Length { get; }
		bool IsReadOnly { get; }
		bool Exists { get; }
	}
}