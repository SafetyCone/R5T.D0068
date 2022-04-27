using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0068
{
    [ServiceDefinitionMarker]
    public interface IApplicationProjectDirectoryPathProvider : IServiceDefinition
    {
        Task<string> GetApplicationProjectDirectoryPath();
    }
}
