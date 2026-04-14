namespace EcommerceDev.Core.Entities;

public class OrderUpdate : BaseEntity
{
    public OrderUpdate(Guid idOrder, string description)
    {
        IdOrder = idOrder;
        Description = description;
    }
    public Guid IdOrder { get; set; }
    public string Description { get; set; }
}