using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;

using R5T.D0067;


namespace R5T.D0068
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ContentRootApplicationProjectDirectoryPathProvider"/> implementation of <see cref="IApplicationProjectDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddContentRootApplicationProjectDirectoryPathProvider(this IServiceCollection services,
            IServiceAction<IContentRootDirectoryPathProvider> contentRootDirectoryPathProviderAction)
        {
            services
                .AddSingleton<IApplicationProjectDirectoryPathProvider, ContentRootApplicationProjectDirectoryPathProvider>()
                .Run(contentRootDirectoryPathProviderAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ContentRootApplicationProjectDirectoryPathProvider"/> implementation of <see cref="IApplicationProjectDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IApplicationProjectDirectoryPathProvider> AddContentRootApplicationProjectDirectoryPathProviderAction(this IServiceCollection services,
            IServiceAction<IContentRootDirectoryPathProvider> contentRootDirectoryPathProviderAction)
        {
            var serviceAction = ServiceAction.New<IApplicationProjectDirectoryPathProvider>(() => services.AddContentRootApplicationProjectDirectoryPathProvider(
                contentRootDirectoryPathProviderAction));

            return serviceAction;
        }
    }
}
