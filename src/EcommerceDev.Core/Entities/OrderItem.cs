namespace EcommerceDev.Core.Entities;

public class OrderItem : BaseEntity
{
    public OrderItem(Guid idProduct, Guid idOrder, int quantity, decimal price)
    {
        IdProduct = idProduct;
        IdOrder = idOrder;
        Quantity = quantity;
        Price = price;
    }

    public Guid IdProduct { get; set; }
    public Guid IdOrder { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}