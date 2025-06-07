public class ProductService : IProductService
{
    public IEnumerable<string> GetProductNames()
    {
        // Here, we'd generally interact with a database
        return new[]
        {
            "Apple",
            "Banana",
            "Cherry"
        };
    }
}