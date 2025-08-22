namespace OnlineStore.Domain.Entities;

public class Customer
{
    public Guid Id { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public string PhoneNumber { get; private set; }
    public ICollection<Order> Orders { get; private set; }

    public Customer(string firstName, string lastName, string email, string phoneNumber)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
    }

    public void UpdateContact(string email, string phone)
    {
        Email = email;
        PhoneNumber = phone;
    }

    public string FullName() => $"{FirstName} {LastName}";
}
