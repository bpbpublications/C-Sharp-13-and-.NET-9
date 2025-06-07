using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class FruitModel : PageModel
{
    private readonly FarmingContext _context;
    public FruitModel(FarmingContext contextontexto)
    {
        _context = contextontexto;
    }

    public IList<Fruit> Fruits { get; set; }

    public async Task OnGetAsync()
    {
        Fruits = await _context.Fruits.ToListAsync();
    }

    // Create
    public async Task<IActionResult> OnPostCreateAsync(string name, int quantity)
    {
        var fruit = new Fruit
        {
            Name = name,
            Quantity = quantity
        };
        _context.Fruits.Add(fruit);
        await _context.SaveChangesAsync();
        return RedirectToPage();
    }

    // Update
    public async Task<IActionResult> OnPostUpdateAsync(int id, string newName, int newQuantity)
    {
        var fruit = await _context.Fruits.FindAsync(id);
        if (fruit == null)
        {
            return NotFound();
        }

        fruit.Name = newName;
        fruit.Quantity = newQuantity;
        await _context.SaveChangesAsync();
        return RedirectToPage();
    }

    // Delete
    public async Task<IActionResult> OnPostDeleteAsync(int id)
    {
        var fruit = await _context.Fruits.FindAsync(id);
        if (fruit == null)
        {
            return NotFound();
        }

        _context.Fruits.Remove(fruit);
        await _context.SaveChangesAsync();
        return RedirectToPage();
    }
}