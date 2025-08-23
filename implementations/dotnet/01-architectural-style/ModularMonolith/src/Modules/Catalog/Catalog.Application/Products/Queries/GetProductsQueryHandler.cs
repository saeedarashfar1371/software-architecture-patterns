using MediatR;
using Microsoft.EntityFrameworkCore;
using Catalog.Application.Common.Interfaces;
using Catalog.Application.Products.Dtos;

namespace Catalog.Application.Products.Queries.GetProducts;

public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, List<ProductDto>>
{
    private readonly ICatalogDbContext _db;

    public GetProductsQueryHandler(ICatalogDbContext db) => _db = db;

    public async Task<List<ProductDto>> Handle(GetProductsQuery request, CancellationToken ct)
    {
        return await _db.Products
            .AsNoTracking()
            .Select(p => new ProductDto(p.Id, p.Name, p.Description, p.Price, p.Stock))
            .ToListAsync(ct);
    }
}
