using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class FarmingContext : DbContext
{
    public DbSet<Farm> Farms { get; set; }
    public DbSet<Crop> Crops { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(@"Server=localhost;Database=FarmingDB;Trusted_Connection=True;");
}

public class Farm
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public List<Crop> Crops { get; set; }
}

public class Crop
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int FarmId { get; set; }
    public Farm Farm { get; set; }
}