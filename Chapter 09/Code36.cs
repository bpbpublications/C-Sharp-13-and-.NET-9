using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class FarmingContext : DbContext
{
    public DbSet<Farm> Farms { get; set; }
    public DbSet<Crop> Crops { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(@"Server=localhost;Database=FarmingDB;Trusted_Connection=True;");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Defining an index on the Location column of the Farm entity
        modelBuilder.Entity<Farm>().HasIndex(f => f.Location).HasDatabaseName("Index_Location");
    }
}