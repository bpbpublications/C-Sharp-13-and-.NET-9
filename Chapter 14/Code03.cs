using Microsoft.EntityFrameworkCore;
using MyEfCoreApp.Models;

namespace MyEfCoreApp.DbContexts;
public class HospitalDbContext : DbContext
{
    public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options)
    {
    }

    public DbSet<Patient>? Patients { get; set; }
    public DbSet<Doctor>? Doctors { get; set; }
    public DbSet<Nursery>? Nurseries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Doctor>().ToTable("Doctors");
        modelBuilder.Entity<Patient>().ToTable("Patients");
        modelBuilder.Entity<Nursery>().ToTable("Nurseries");
    }
}