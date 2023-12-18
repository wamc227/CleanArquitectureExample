using LatinoNet.Presenters;
using LatinoNet.Repository;
using LatinoNet.UseCases;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LatinoNet.IoC
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddLatinoNetDepencies(
                this IServiceCollection services,IConfiguration configuration)
        {
            services.AddRepositories(configuration);
            services.AddUseCasesServices();
            services.AddPresenters();
            return services;
        }
    }
}
