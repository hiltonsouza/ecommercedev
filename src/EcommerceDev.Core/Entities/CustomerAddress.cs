namespace EcommerceDev.Core.Entities;

public class CustomerAddress : BaseEntity
{
    protected CustomerAddress() { }
    public CustomerAddress(Guid idCustomer, string addressLine1, string? addressLine2, string zipCode, string district, string state, string city, string country, string recipientName)
    {
        IdCustomer = idCustomer;
        AddressLine1 = addressLine1;
        AddressLine2 = addressLine2;
        ZipCode = zipCode;
        District = district;
        State = state;
        City = city;
        Country = country;
        RecipientName = recipientName;
    }
    

    public Guid IdCustomer { get; set; }
    public string RecipientName { get; set; }
    public string AddressLine1 { get; set; }
    public string? AddressLine2 { get; set; }
    public string ZipCode { get; set; }
    public string District { get; set; }
    public string State { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
}