namespace EcommerceDev.Application.Commands.Orders.CreateOrder;
public class CreateOrderCommand
{
    public Guid IdCustomer { get; set; }
    public List<CreateOrderCommandItem> Items { get; set; } = [];
    public Guid DeliveryAddressId { get; set; }
}

public class CreateOrderCommandItem
{
    public Guid IdProduct { get; set; }
    public int Quantity { get; set; }
}