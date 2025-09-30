using Pb305OnionArc.Application.Common.Interfaces;
using Pb305OnionArc.Domain.Common;

namespace Pb305OnionArc.Persistance.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options), IAppDbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    //public DbSet<Order> Orders { get; set; }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
        
        return await base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
