using Microsoft.EntityFrameworkCore;
using SnapFolio.Models;

namespace SnapFolio.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<SkillsCategory> Categories { get; set; }
    public DbSet<SkillItem> Items { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<ExperienceDetail> ExperienceDetails { get; set; }
    public DbSet<Education> Educations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SkillsCategory>()
            .HasMany(e => e.Items)
            .WithOne(e => e.Category)
            .HasForeignKey(e => e.CategoryId);

        base.OnModelCreating(modelBuilder);
    }
}
