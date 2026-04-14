namespace EcommerceDev.Core.Entities;

public class OrderProductReview : BaseEntity
{
    public OrderProductReview(Guid idOrderItem, Guid idCustomer, string title, string description, int score)
    {
        IdOrderItem = idOrderItem;
        IdCustomer = idCustomer;
        Title = title;
        Description = description;
        Score = score;
    }
    public Guid IdOrderItem { get; set; }
    public Guid IdCustomer { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Score { get; set; }
}