using MediatR;
using OnlineStore.Application.Products.Queries;
using OnlineStore.Domain.Entities;
using OnlineStore.Domain.Interfaces;

namespace OnlineStore.Application.Products.Commands;

public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetProductByIdHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Product> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
    {
        return await _unitOfWork.ProductRepository.GetByIdAsync(query.Id);
    }
}
