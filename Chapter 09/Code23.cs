using Microsoft.EntityFrameworkCore;

public class FarmingContext : DbContext
{
    public DbSet<Farm> Farms { get; set; }
    public DbSet<Fruit> Fruits { get; set; }
    public DbSet<DistributionCenter> DistributionCenters { get; set; }
    public DbSet<Market> Markets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(@"Server=localhost;Database=FarmingDB;Trusted_Connection=True;");
}

public class Farm
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Fruit> Fruits { get; set; }
}

public class Fruit
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public int FarmId { get; set; }
    public Farm Farm { get; set; }
}

public class DistributionCenter
{
    public int Id { get; set; }
    public string Location { get; set; }
    public List<Market> Markets { get; set; }
}

public class Market
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int DistributionCenterId { get; set; }
    public DistributionCenter DistributionCenter { get; set; }
}