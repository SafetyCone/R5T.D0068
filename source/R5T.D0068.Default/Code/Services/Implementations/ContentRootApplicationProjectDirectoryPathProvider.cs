using System;
using System.Threading.Tasks;

using R5T.D0067;


namespace R5T.D0068
{
    public class ContentRootApplicationProjectDirectoryPathProvider : IApplicationProjectDirectoryPathProvider
    {
        private IContentRootDirectoryPathProvider ContentRootDirectoryPathProvider { get; }


        public ContentRootApplicationProjectDirectoryPathProvider(
            IContentRootDirectoryPathProvider contentRootDirectoryPathProvider)
        {
            this.ContentRootDirectoryPathProvider = contentRootDirectoryPathProvider;
        }

        public Task<string> GetApplicationProjectDirectoryPath()
        {
            // Just return the content root directory path.
            return this.ContentRootDirectoryPathProvider.GetContentRootDirectoryPath();
        }
    }
}
