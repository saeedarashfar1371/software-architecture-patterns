using BuildingBlocks;
using Catalog.Api;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddModules(builder.Configuration,
    new CatalogModule()
    //new OrderingModule()
);

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "OnlineStore API", Version = "v1" });
});

var app = builder.Build();

//if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapModules();

app.Run();
