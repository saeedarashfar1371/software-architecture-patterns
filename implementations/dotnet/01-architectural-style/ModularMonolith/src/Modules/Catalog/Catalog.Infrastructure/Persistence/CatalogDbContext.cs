using Microsoft.EntityFrameworkCore;
using Catalog.Application.Common.Interfaces;
using Catalog.Domain.Entities;

namespace Catalog.Infrastructure.Persistence;

public class CatalogDbContext : DbContext, ICatalogDbContext
{
    public CatalogDbContext(DbContextOptions<CatalogDbContext> options) : base(options) { }

    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>(b =>
        {
            b.HasKey(p => p.Id);
            b.Property(p => p.Name).IsRequired().HasMaxLength(200);
            b.Property(p => p.Price).HasColumnType("decimal(18,2)");
            b.Property(p => p.Stock).IsRequired();
        });
    }
}
