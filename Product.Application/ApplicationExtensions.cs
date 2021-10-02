using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductNS.Application.Services;
using ProductNS.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProductNS.Application
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddApplicationModule(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<IProductService, ProductService>();

            services.AddInfrastructureModule(configuration);
            
            return services; 
        }
    }
}
