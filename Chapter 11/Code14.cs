using Microsoft.AspNetCore.Mvc.RazorPages;

public class DetailsModel : PageModel
{
    public int ProductId { get; private set; }

    public void OnGet(int id)
    {
        ProductId = id;
    }
}