using Microsoft.AspNetCore.Mvc.RazorPages;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class ProductsModel : PageModel
{
    public List<Product> Products { get; private set; } = new List<Product>();

    public void OnGet()
    {
        // Initialize with some data for demonstration purposes
        Products.Add(new Product { Name = "Apple", Price = 1.99M });
        Products.Add(new Product { Name = "Banana", Price = 0.99M });
    }

    public void OnPost()
    {
        // Reload or refresh the product list could be fetched from a database
        Products.Add(new Product { Name = "Cherry", Price = 2.99M });
    }
}