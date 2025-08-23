using BuildingBlocks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Catalog.Application;
using Catalog.Infrastructure;
using Catalog.Application.Products.Commands.CreateProduct;
using MediatR;
using Microsoft.AspNetCore.Routing;
using Catalog.Application.Products.Queries.GetProducts;
using Microsoft.AspNetCore.Http;

namespace Catalog.Api;

public class CatalogModule : IModule
{
    public void RegisterServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddCatalogApplication();
        services.AddCatalogInfrastructure(configuration);
    }

    public void MapEndpoints(WebApplication app)
    {
        var group = app.MapGroup("/api/catalog");

        group.MapGet("/products", async (IMediator mediator) =>
        {
            var data = await mediator.Send(new GetProductsQuery());
            return Results.Ok(data);
        });

        group.MapPost("/products", async (IMediator mediator, CreateProductCommand cmd) =>
        {
            var id = await mediator.Send(cmd);
            return Results.Created($"/api/catalog/products/{id}", new { id });
        });
    }
}
