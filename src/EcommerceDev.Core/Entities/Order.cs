using EcommerceDev.Core.Enums;

namespace EcommerceDev.Core.Entities;

public class Order : BaseEntity
{
    public Order(Guid idCustomer, DateTime? confirmationDate, DateTime? shippingDate, OrderStatus status, Guid deliveryAddressId, decimal shippingPrice, decimal totalProductsPrice, List<OrderItem> items)
    {
        IdCustomer = idCustomer;
        ConfirmationDate = confirmationDate;
        ShippingDate = shippingDate;
        Status = status;
        DeliveryAddressId = deliveryAddressId;
        ShippingPrice = shippingPrice;
        TotalProductsPrice = totalProductsPrice;
        Items = items;

        Updates = [];
    }
    public Guid IdCustomer { get; set; }
    public DateTime? ConfirmationDate { get; set; }
    public DateTime? ShippingDate { get; set; }
    public OrderStatus Status { get; set; }
    public Guid DeliveryAddressId { get; set; }
    public decimal ShippingPrice { get; set; }
    public decimal TotalProductsPrice { get; set; }
    public List<OrderItem> Items { get; set; }
    public List<OrderUpdate> Updates { get; set; }
}