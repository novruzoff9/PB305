using CarManagement.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace CarManagement.DAL.Context;

public class AppDbContext : DbContext
{
    private readonly string _connectionString = "server=DESKTOP-93814R2;database=Pb305CarManage;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure entity relationships and properties here
        base.OnModelCreating(modelBuilder);
    }
    // Define DbSets for your entities
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Model> Models { get; set; }
}
