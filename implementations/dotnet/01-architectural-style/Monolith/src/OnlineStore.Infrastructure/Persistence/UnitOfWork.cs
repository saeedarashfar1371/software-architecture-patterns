using OnlineStore.Domain.Interfaces;

namespace OnlineStore.Infrastructure.Persistence;

public class UnitOfWork : IUnitOfWork
{
    private readonly OnlineStoreDbContext _context;
    public IProductRepository ProductRepository { get; set; }

    public UnitOfWork(OnlineStoreDbContext context, IProductRepository productRepository)
    {
        _context = context;
        ProductRepository = productRepository;
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await _context.SaveChangesAsync(cancellationToken);
    }
}
