using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BuildingBlocks;

public static class ModuleEndpointLoader
{
    public static void MapModules(this WebApplication app)
    {
        var modules = app.Services.GetRequiredService<List<IModule>>();
        foreach (var module in modules)
        {
            module.MapEndpoints(app);
        }
    }
}
