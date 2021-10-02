using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ProductNS.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductNS.Infrastructure
{
    public static class InfrastructureExtensions
    {
        public static IServiceCollection AddInfrastructureModule(this IServiceCollection services, IConfiguration configuration)
        {
            /*
            services.AddDbContext<ProductContext>(opt =>
                                   opt.UseInMemoryDatabase("Products"));
            */

            services.AddDbContext<ProductContext>(options =>
                options
                    .UseNpgsql(configuration.GetConnectionString("ProductContext"))
                    .UseSnakeCaseNamingConvention()
                    .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
                    .EnableSensitiveDataLogging()
            );

            //Displays detailed error pages
            services.AddDatabaseDeveloperPageExceptionFilter();

            //TODO: Implement and add repositories

            return services;
        }
    }
}
