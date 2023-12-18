using LatinoNet.UseCases.CreateProduct;
using LatinoNet.UseCases.GetAllProducts;
using LatinoNet.UseCases.GetProduct;
using LatinoNet.UseCasesPorts;
using Microsoft.Extensions.DependencyInjection;

namespace LatinoNet.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
        {
            services.AddTransient<ICreateProductInputPort, CreateProductInteractor>();
            services.AddTransient<IGetAllProductsInputPort, GetAllProductsInteractor>();
            services.AddTransient<IGetProductInputPort, GetProductInteractor>();
            return services;
        }
    }
}
