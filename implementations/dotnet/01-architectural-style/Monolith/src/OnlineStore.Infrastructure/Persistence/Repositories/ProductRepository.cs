using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Entities;
using OnlineStore.Domain.Interfaces;

namespace OnlineStore.Infrastructure.Persistence.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly OnlineStoreDbContext _context;

    public ProductRepository(OnlineStoreDbContext context)
    {
        _context = context;
    }

    public IUnitOfWork UnitOfWork { get; }

    public async Task<Product> GetByIdAsync(Guid id) =>
        await _context.Products.FindAsync(id);

    public async Task<List<Product>> GetAllAsync() =>
        await _context.Products.ToListAsync();

    public async Task AddAsync(Product product) =>
        await _context.Products.AddAsync(product);

    public Task UpdateAsync(Product product)
    {
        _context.Products.Update(product);
        return Task.CompletedTask;
    }

    public Task DeleteAsync(Product product)
    {
        _context.Products.Remove(product);
        return Task.CompletedTask;
    }
}
