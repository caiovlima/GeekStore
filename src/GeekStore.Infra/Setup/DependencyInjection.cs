using System.Reflection;
using Microsoft.Extensions.DependencyInjection;


namespace GeekStore.Infra.Setup
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfra(this IServiceCollection services)
        {
            //services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
