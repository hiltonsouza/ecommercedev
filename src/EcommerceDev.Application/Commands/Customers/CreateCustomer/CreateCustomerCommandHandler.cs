using EcommerceDev.Application.Common;

namespace EcommerceDev.Application.Commands.Customers.CreateCustomer;

public class CreateCustomerCommandHandler : IHandler<CreateCustomerCommand, ResultViewModel<Guid>>
{
    public Task<ResultViewModel<Guid>> HandleAsync(CreateCustomerCommand request)
    {
        throw new NotImplementedException();
    }
}