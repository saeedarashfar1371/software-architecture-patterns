// Catalog.Application/Products/Commands/CreateProduct/CreateProductCommand.cs
using MediatR;
using Catalog.Application.Products.Dtos;

namespace Catalog.Application.Products.Commands.CreateProduct;

public record CreateProductCommand(string Name, string? Description, decimal Price, int Stock) : IRequest<Guid>;
