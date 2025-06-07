using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyAppRazorPage.Pages;
public class Customer
{
    public string Name { get; set; }
    public string Email { get; set; }
}

public class CustomerPageModel : PageModel
{
    [BindProperty]
    public Customer Customer { get; set; }

    public void OnGet()
    {
    // Initialization code if needed
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Handle the customer data, e.g., save to the database
        // ...
        return RedirectToPage("./Success");
    }
}