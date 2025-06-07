using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorPagesApp.Pages;
public class ContactModel : PageModel
{
    [BindProperty]
    public string Name { get; set; }

    [BindProperty]
    public string Message { get; set; }

    public void OnPost()
    {
    // Handle form submission
    }
}