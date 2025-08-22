namespace OnlineStore.Domain.ValueObjects;

public class Address
{
    public string Street { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string ZipCode { get; private set; }
    public string Country { get; private set; }

    public Address(string street, string city, string state, string zipCode, string country)
    {
        if (string.IsNullOrWhiteSpace(street) || string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(country))
            throw new ArgumentException("Street, city, and country are required.");

        Street = street;
        City = city;
        State = state;
        ZipCode = zipCode;
        Country = country;
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Address other) return false;
        return Street == other.Street &&
               City == other.City &&
               State == other.State &&
               ZipCode == other.ZipCode &&
               Country == other.Country;
    }

    public override int GetHashCode() => HashCode.Combine(Street, City, State, ZipCode, Country);
}
