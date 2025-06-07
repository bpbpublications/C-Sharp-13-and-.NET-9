using Microsoft.EntityFrameworkCore;

public class FarmingContext : DbContext
{
    public DbSet<Farm> Farms { get; set; }
    public DbSet<Fruit> Fruits { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(@"”Server=localhost;Database=FarmingDB;Trusted_Connection=True;" ”);
}

public class Farm
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Fruit
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public int FarmId { get; set; }
    public Farm Farm { get; set; }
}