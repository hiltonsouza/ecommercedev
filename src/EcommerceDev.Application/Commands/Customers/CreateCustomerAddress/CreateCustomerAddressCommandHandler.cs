using EcommerceDev.Application.Common;

namespace EcommerceDev.Application.Commands.Customers.CreateCustomerAddress;

public class CreateCustomerAddressCommandHandler :
    IHandler<CreateCustomerAddressCommand, ResultViewModel<Guid>>
{
    public Task<ResultViewModel<Guid>> HandleAsync(CreateCustomerAddressCommand request)
    {
        throw new NotImplementedException();
    }
}