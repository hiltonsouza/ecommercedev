using EcommerceDev.Application.Common;

namespace EcommerceDev.Application.Commands.Orders.CreateOrder;

public class CreateOrderCommandHandler : IHandler<CreateOrderCommand, Guid>
{
    public Task<Guid> HandleAsync(CreateOrderCommand request)
    {
        throw new NotImplementedException();
    }
}