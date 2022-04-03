namespace System.Diagnostics.Abstracted
{
    public class FileVersionInfoFactory : IFileVersionInfoFactory
    {
        /// <inheritdoc />
        public IFileVersionInfo GetVersionInfo(string path)
        {
            return new FileVersionInfoWrapper(FileVersionInfo.GetVersionInfo(path));
        }
    }
}