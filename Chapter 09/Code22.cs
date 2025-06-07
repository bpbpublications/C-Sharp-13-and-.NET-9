using Microsoft.EntityFrameworkCore;

public class FarmingContext : DbContext
{
    public DbSet<Farm> Farms { get; set; }
    public DbSet<Crop> Crops { get; set; }
    public DbSet<Vegetable> Vegetables { get; set; }
    public DbSet<Rice> Rices { get; set; }
    public DbSet<Bean> Beans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(@"Server=localhost;Database=FarmingDB;Trusted_Connection=True;");
}