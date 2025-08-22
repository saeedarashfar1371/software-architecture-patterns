using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using System.Reflection;
using OnlineStore.Application.Services;

namespace OnlineStore.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddAutoMapper(cfg => { }, Assembly.GetExecutingAssembly());

        services.AddScoped<ITaxCalculator, TaxCalculator>();

        return services;
    }
}
