using System;
using System.Threading.Tasks;


namespace R5T.D0068
{
    public interface IApplicationProjectDirectoryPathProvider
    {
        Task<string> GetApplicationProjectDirectoryPath();
    }
}
