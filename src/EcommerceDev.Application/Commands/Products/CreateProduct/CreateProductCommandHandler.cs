using EcommerceDev.Application.Common;

namespace EcommerceDev.Application.Commands.Products.CreateProduct;

public class CreateProductCommandHandler :
    IHandler<CreateProductCommand, ResultViewModel<Guid>>
{
    public Task<ResultViewModel<Guid>> HandleAsync(CreateProductCommand request)
    {
        throw new NotImplementedException();
    }
}