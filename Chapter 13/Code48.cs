// POST: Products/Edit/5
using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;

[HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price")] Product product)
{
    if (id != product.Id)
    {
        return NotFound();
    }

    if (!ModelState.IsValid)
        return View(product);
    try
    {
        context.Update(product);
        await context.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        if (!ProductExists(product.Id))
        {
            return NotFound();
        }
        else
        {
            throw;
        }
    }

    return RedirectToAction(nameof(Index));
}