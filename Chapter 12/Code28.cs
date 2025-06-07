using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    private readonly IProductService _productService;
    public IndexModel(IProductService productService)
    {
        _productService = productService;
    }

    public IEnumerable<string> ProductNames { get; private set; }

    public void OnGet()
    {
        ProductNames = _productService.GetProductNames();
    }

    public void OnPost()
    {
        ProductNames = _productService.GetProductNames();
    // Additional logic for post request
    }
}