using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace MyRazorPagesApp.Pages;
public class ContactModel : PageModel
{
    [BindProperty]
    public string Name { get; set; }

    [BindProperty]
    [EmailAddress]
    public string Email { get; set; }

    [BindProperty]
    public string Message { get; set; }
    public bool MessageSent { get; set; }

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Process the data here (e.g., save it to the database)
        // For this example, we'll  simulate that the message is sent
        MessageSent = true;
        // You can redirect to another page or  return to the same page
        return Page();
    }
}

(lead - in here )