public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public decimal Price { get; set; }
    public string Genre { get; set; }
    public string Description { get; set; }
    public DateTime PublishDate { get; set; }
    public int StockQuantity { get; set; }

    // Business Logic: Determines if the book is a best-seller
    public bool IsBestseller()
    {
        // logic to determine if the book is a best-seller
        // This could be based on sales, ratings, etc.
        return true; // Placeholder return value
    }

    // Business Logic: Calculates the discount price of the book
    public decimal CalculateDiscountPrice(decimal discountPercentage)
    {
        return Price - (Price * discountPercentage / 100);
    }
}