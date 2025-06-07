using Microsoft.EntityFrameworkCore;

public class FarmingContext : DbContext
{
    public DbSet<Farm> Farms { get; set; }
    public DbSet<Fruit> Fruits { get; set; }
    public DbSet<ExoticFruit> ExoticFruits { get; set; }

    // Other DbSets...
    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(@"Server=localhost;Database=FarmingDB;Trusted_Connection=True;");
}