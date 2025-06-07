using Microsoft.AspNetCore.Mvc;

public async Task<IActionResult> OnPostDeleteAsync(int id)
{
    var item = await _context.Items.FindAsync(id);
    if (item != null)
    {
        _context.Items.Remove(item);
        await _context.SaveChangesAsync();
    }

    return RedirectToPage("./Index");
}