using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;

public async Task<IActionResult> OnPostAsync()
{
    if (!ModelState.IsValid)
    {
        return Page();
    }

    _context.Items.Add(Item);
    await _context.SaveChangesAsync();
    return RedirectToPage("./Index");
}