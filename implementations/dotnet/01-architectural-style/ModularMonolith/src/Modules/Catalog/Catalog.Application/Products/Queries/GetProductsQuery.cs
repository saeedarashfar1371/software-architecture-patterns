// Catalog.Application/Products/Queries/GetProducts/GetProductsQuery.cs
using MediatR;
using Catalog.Application.Products.Dtos;

namespace Catalog.Application.Products.Queries.GetProducts;

public record GetProductsQuery() : IRequest<List<ProductDto>>;
