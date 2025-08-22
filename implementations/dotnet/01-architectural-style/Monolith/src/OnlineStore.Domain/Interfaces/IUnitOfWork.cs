namespace OnlineStore.Domain.Interfaces;

public interface IUnitOfWork
{
    public IProductRepository ProductRepository { get; set; }   
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
