namespace System.Diagnostics.Abstracted
{
    public class FileVersionInfo : IFileVersionInfo
    {
        private readonly System.Diagnostics.FileVersionInfo inner;

        /// <inheritdoc />
        protected internal FileVersionInfo(System.Diagnostics.FileVersionInfo inner)
        {
            this.inner = inner;
        }

        /// <inheritdoc />
        public string Comments => inner.Comments;

        /// <inheritdoc />
        public string CompanyName => inner.CompanyName;

        /// <inheritdoc />
        public int FileBuildPart => inner.FileBuildPart;

        /// <inheritdoc />
        public string FileDescription => inner.FileDescription;

        /// <inheritdoc />
        public int FileMajorPart => inner.FileMajorPart;

        /// <inheritdoc />
        public int FileMinorPart => inner.FileMinorPart;

        /// <inheritdoc />
        public string FileName => inner.FileName;

        /// <inheritdoc />
        public int FilePrivatePart => inner.FilePrivatePart;

        /// <inheritdoc />
        public string FileVersion => inner.FileVersion;

        /// <inheritdoc />
        public string InternalName => inner.InternalName;

        /// <inheritdoc />
        public bool IsDebug => inner.IsDebug;

        /// <inheritdoc />
        public bool IsPatched => inner.IsPatched;

        /// <inheritdoc />
        public bool IsPrivateBuild => inner.IsPrivateBuild;

        /// <inheritdoc />
        public bool IsPreRelease => inner.IsPreRelease;

        /// <inheritdoc />
        public bool IsSpecialBuild => inner.IsSpecialBuild;

        /// <inheritdoc />
        public string Language => inner.Language;

        /// <inheritdoc />
        public string LegalCopyright => inner.LegalCopyright;

        /// <inheritdoc />
        public string LegalTrademarks => inner.LegalTrademarks;

        /// <inheritdoc />
        public string OriginalFilename => inner.OriginalFilename;

        /// <inheritdoc />
        public string PrivateBuild => inner.PrivateBuild;

        /// <inheritdoc />
        public int ProductBuildPart => inner.ProductBuildPart;

        /// <inheritdoc />
        public int ProductMajorPart => inner.ProductMajorPart;

        /// <inheritdoc />
        public int ProductMinorPart => inner.ProductMinorPart;

        /// <inheritdoc />
        public string ProductName => inner.ProductName;

        /// <inheritdoc />
        public int ProductPrivatePart => inner.ProductPrivatePart;

        /// <inheritdoc />
        public string ProductVersion => inner.ProductVersion;

        /// <inheritdoc />
        public string SpecialBuild => inner.SpecialBuild;
    }
}