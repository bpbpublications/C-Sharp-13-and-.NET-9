public class Customer
{
    public string Name { get; set; }

    // This method could be moved to a CustomerRepository class
    public void SaveToDatabase()
    {
    // Save to database...
    }
}