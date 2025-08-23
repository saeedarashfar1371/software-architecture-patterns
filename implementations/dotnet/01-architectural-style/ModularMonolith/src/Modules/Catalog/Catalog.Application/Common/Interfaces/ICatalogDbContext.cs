using Microsoft.EntityFrameworkCore;
using Catalog.Domain.Entities;

namespace Catalog.Application.Common.Interfaces;

public interface ICatalogDbContext
{
    DbSet<Product> Products { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
