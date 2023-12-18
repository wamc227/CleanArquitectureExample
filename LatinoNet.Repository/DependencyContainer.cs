using LatinoNet.Entities.Interfaces;
using LatinoNet.Repository.DataContext;
using LatinoNet.Repository.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.Repository
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<LatinoNetContext>(
                    options=>options.UseSqlServer(
                            configuration.GetConnectionString("defaultConnectionString")));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
