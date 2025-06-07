// Importing necessary namespaces
using Microsoft.EntityFrameworkCore;
using MyEfCoreApp.Models;

namespace MyEfCoreApp.DbContexts;
// Defining HospitalContext class which inherits from DbContext
public class HospitalContext : DbContext
{
    // Constructor for HospitalContext, receiving DbContextOptions and passing them to the base DbContext class
    public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
    {
    }

    // Declaring a DbSet property for Patient. This will map to a database table and provide access to Patient entities.
    public DbSet<Patient>? Patients { get; set; }

    // Overriding the OnModelCreating method to configure the model that Entity Framework uses to create the database schema
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Specifying that the Patient entity maps to a table named "Patient" in the database
        modelBuilder.Entity<Patient>().ToTable("Patients");
    }
}