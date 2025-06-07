using Microsoft.AspNetCore.Mvc;

public async Task<IActionResult> OnPostAsync(int id)
{
    var itemToUpdate = await _context.Items.FindAsync(id);
    if (itemToUpdate == null)
    {
        return NotFound();
    }

    if (await TryUpdateModelAsync<Item>(itemToUpdate, "item", // Prefix for form value.
 i => i.Name, i => i.OtherProperty))
    {
        await _context.SaveChangesAsync();
        return RedirectToPage("./Index");
    }

    return Page();
}