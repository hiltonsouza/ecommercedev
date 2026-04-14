namespace EcommerceDev.Core.Entities;

public class Customer : BaseEntity
{
    public Customer(string fullName, string email, string phoneNumber, DateTime birthDate, string document)
    {
        FullName = fullName;
        Email = email;
        PhoneNumber = phoneNumber;
        BirthDate = birthDate;
        Document = document;

        Addresses = [];
    }

    public string FullName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime BirthDate { get; set; }
    public string Document { get; set; }
    public List<CustomerAddress> Addresses { get; set; }
}