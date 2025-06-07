namespace MyEfCoreApp.DbContexts;
using Microsoft.EntityFrameworkCore;
using MyEfCoreApp.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Product>? Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Specifying that the Products entity maps to a table named "Products" in the database
        modelBuilder.Entity<Product>().ToTable("Products");
    }
}