using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using GeekStore.Application.Product.Interfaces;
using GeekStore.Infra.Repository;


namespace GeekStore.Infra.Setup
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfra(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }
    }
}
