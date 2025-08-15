using MediatR;
using OnlineStore.Domain.Interfaces;

namespace OnlineStore.Application.Products.Commands.CreateProduct;

public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Guid>
{
    private readonly IUnitOfWork _unitOfWork;

    public UpdateProductCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Guid> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        //var product = new Product(request.Name, request.Description, request.Price, request.Stock);
        //var product = _mapper.Map<Product>(request);

        var product = await _unitOfWork.ProductRepository.GetByIdAsync(request.Id);
        if (product == null)
        {
            return Guid.Empty;
        }
        else
        {
            product.UpdateStock(request.Stock);
            product.UpdatePrice(request.Price);
            product.UpdateName(request.Name);
            product.UpdateDescription(request.Description);

            await _unitOfWork.ProductRepository.UpdateAsync(product);
            await _unitOfWork.SaveChangesAsync();

            return product.Id;
        }
    }
}
