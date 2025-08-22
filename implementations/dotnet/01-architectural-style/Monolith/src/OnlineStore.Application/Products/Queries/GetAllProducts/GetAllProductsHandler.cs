using MediatR;
using OnlineStore.Application.Products.Queries;
using OnlineStore.Domain.Entities;
using OnlineStore.Domain.Interfaces;

namespace OnlineStore.Application.Products.Commands;

public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, IList<Product>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetAllProductsHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IList<Product>> Handle(GetAllProductsQuery query, CancellationToken cancellationToken)
    {
        return await _unitOfWork.ProductRepository.GetAllAsync();
    }
}
