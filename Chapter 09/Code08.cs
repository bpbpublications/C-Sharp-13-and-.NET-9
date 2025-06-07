using Microsoft.EntityFrameworkCore;

public class FarmingContext : DbContext
{
    public DbSet<Farm> Farms { get; set; }
    public DbSet<Crop> Crops { get; set; }
    public DbSet<Vegetable> Vegetables { get; set; }
    // Removed DbSet<Rice> Rices { get; set; }
    // Removed DbSet<Bean> Beans { get; set; }
    public DbSet<Fruit> Fruits { get; set; }
    public DbSet<Egg> Eggs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(@"Server=localhost;Database=FarmingDB;Trusted_Connection=True;");
}

public class Farm
{ /*... same as before ...*/
}

public class Crop
{ /*... same as before ...*/
}

public class Vegetable
{ /*... same as before ...*/
}

public class Fruit
{ /*... new definition ...*/
}

public class Egg
{ /*... new definition ...*/
}