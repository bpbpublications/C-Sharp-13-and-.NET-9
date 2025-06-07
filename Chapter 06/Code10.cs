public interface IProduct
{
    string Name { get; }

    decimal Price { get; }

    void DisplayDetails();
    void ApplyDiscount(decimal discountAmount);
}