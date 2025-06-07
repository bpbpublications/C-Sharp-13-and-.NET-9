using Microsoft.EntityFrameworkCore;

public class FarmingContext : DbContext
{
    private readonly string _databaseProvider;
    public FarmingContext(string databaseProvider)
    {
        _databaseProvider = databaseProvider;
    }

    public DbSet<Farm> Farms { get; set; }
    public DbSet<Fruit> Fruits { get; set; }
    public DbSet<DistributionCenter> DistributionCenters { get; set; }
    public DbSet<Market> Markets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        if (_databaseProvider == "SQLServer")
        {
            options.UseSqlServer(@"Server=localhost;Database=FarmingDB;Trusted_Connection=True;");
        }
        else if (_databaseProvider == "MySQL")
        {
            options.UseMySql(@"Server=localhost;Database=FarmingDB;User=root;Password=your_password;", new MySqlServerVersion(new Version(8, 0, 21)));
        }
    }
}