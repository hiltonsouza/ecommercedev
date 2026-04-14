namespace EcommerceDev.Core.Entities;

public class Product : BaseEntity
{
    public Product(string title, string description, decimal price, string brand, int quantity, ProductCategory category, Guid idCategory)
    {
        Title = title;
        Description = description;
        Price = price;
        Brand = brand;
        Quantity = quantity;
        Category = category;
        IdCategory = idCategory;
    }

    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Brand { get; set; }
    public int Quantity { get; set; }
    public Guid IdCategory { get; set; }
    public ProductCategory Category { get; set; }
    
}