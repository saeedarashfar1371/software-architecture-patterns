using OnlineStore.Domain.Entities;

namespace OnlineStore.Domain.Interfaces;

public interface IProductRepository
{
    Task<Product> GetByIdAsync(Guid id);
    Task<List<Product>> GetAllAsync();
    Task AddAsync(Product product);
    Task UpdateAsync(Product product);
    Task DeleteAsync(Product product);
    IUnitOfWork UnitOfWork { get; }
}
