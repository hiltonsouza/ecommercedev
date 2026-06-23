namespace EcommerceDev.Core.Entities;

public class ProductImage : BaseEntity
{
    protected ProductImage() { }
    public ProductImage(Guid idProduct, string identifier, string path, bool isVisible)
    {
        IdProduct = idProduct;
        Identifier = identifier;
        Path = path;
        IsVisible = isVisible;
    }

    public Guid IdProduct { get; set; }
    public string Identifier { get; set; }
    public string Path { get; set; }
    public bool IsVisible { get; set; }
}