public IList<Item> Items { get; set; }

public async Task OnGetAsync()
{
    Items = await _context.Items.ToListAsync();
}