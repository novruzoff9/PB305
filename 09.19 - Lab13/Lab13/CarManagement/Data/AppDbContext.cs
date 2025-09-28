using CarManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace CarManagement.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Model> Models { get; set; }
}
