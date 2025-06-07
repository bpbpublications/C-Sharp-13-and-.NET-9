public class Book : IProduct
{
    public string Name { get; private set; }
    public decimal Price { get; private set; }

    public Book(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Book: {Name}, Price: {Price}");
    }

    public void ApplyDiscount(decimal discountAmount)
    {
        Price -= discountAmount;
    }
}

public class Electronics : IProduct
{
    public string Name { get; private set; }
    public decimal Price { get; private set; }

    public Electronics(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Electronics: {Name}, Price: {Price}");
    }

    public void ApplyDiscount(decimal discountAmount)
    {
        Price -= discountAmount;
    }
}