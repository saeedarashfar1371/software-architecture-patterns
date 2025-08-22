using MediatR;
using OnlineStore.Domain.Interfaces;

namespace OnlineStore.Application.Products.Commands.CreateProduct;

public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, Guid>
{
    private readonly IUnitOfWork _unitOfWork;

    public DeleteProductCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Guid> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        var product = await _unitOfWork.ProductRepository.GetByIdAsync(request.Id);
        if (product == null)
        {
            return Guid.Empty;
        }
        else
        {
            await _unitOfWork.ProductRepository.DeleteAsync(product);
            await _unitOfWork.SaveChangesAsync();

            return product.Id;
        }
    }
}
