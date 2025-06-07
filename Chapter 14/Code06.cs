public interface INurseryRepository
{
    Task<IEnumerable<Nursery>> GetAllAsync();
    Task<Nursery> GetByIdAsync(int id);
// Other necessary methods...
}

public class NurseryRepository : INurseryRepository
{
    private readonly NurseryDbContext _context;
    public NurseryRepository(NurseryDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Nursery>> GetAllAsync()
    {
        return await _context.Nurseries.ToListAsync();
    }

    public async Task<Nursery> GetByIdAsync(int id)
    {
        return await _context.Nurseries.FindAsync(id);
    }
}