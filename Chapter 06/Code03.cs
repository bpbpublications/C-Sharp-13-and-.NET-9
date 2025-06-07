// Book class implementing IBook and IRentable interfaces
public class Book : IBook, IRentable
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Author { get; set; }
    public int RentalPeriodInDays { get; set; }

    public void Rent()
    {
        Console.WriteLine($"Book {Name} by {Author} has been rented.");
    }
}