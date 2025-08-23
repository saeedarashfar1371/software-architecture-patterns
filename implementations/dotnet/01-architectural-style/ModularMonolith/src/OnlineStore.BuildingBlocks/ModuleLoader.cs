using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BuildingBlocks;

public static class ModuleLoader
{
    public static void AddModules(this IServiceCollection services, IConfiguration config, params IModule[] modules)
    {
        foreach (var module in modules)
        {
            module.RegisterServices(services, config);
        }

        // save all modules in list for future using
        services.AddSingleton(modules.ToList());
    }
}
