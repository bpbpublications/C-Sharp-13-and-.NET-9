public class Purchase
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public Address BillingAddress { get; set; }
    public Address DeliveryAddress { get; set; }
// Other properties like Amount, CustomerId, etc.
}

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
// Additional address details
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Role { get; set; }
// Other user properties
}