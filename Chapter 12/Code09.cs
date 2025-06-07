using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class ProductsModel : PageModel
{
    public List<Product> Products { get; private set; }

    public void OnGet()
    {
        // In a real application, you would fetch this data from a database
        Products = new List<Product>
        {
            new Product
            {
                Name = "Laptop",
                Price = 999.99M
            },
            new Product
            {
                Name = "Smartphone",
                Price = 499.99M
            },
            new Product
            {
                Name = "Tablet",
                Price = 299.99M
            }
        };
    }
}