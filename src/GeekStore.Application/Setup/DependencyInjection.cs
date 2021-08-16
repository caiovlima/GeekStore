using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using MediatR;
using GeekStore.Application.Product.Commands.CreateProduct.Validations;

namespace GeekStore.Application.Setup
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssemblyContaining<CreateProductCommandValidator>();

            return services;
        }
    }
}
