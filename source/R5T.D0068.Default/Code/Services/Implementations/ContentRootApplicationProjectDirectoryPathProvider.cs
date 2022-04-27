using System;
using System.Threading.Tasks;

using R5T.D0067;
using R5T.T0064;


namespace R5T.D0068
{
    [ServiceImplementationMarker]
    public class ContentRootApplicationProjectDirectoryPathProvider : IApplicationProjectDirectoryPathProvider, IServiceImplementation
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
