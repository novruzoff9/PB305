using Microsoft.EntityFrameworkCore;

namespace Pb305OnionArc.Application.Common.Interfaces;

public interface IAppDbContext
{
    DbSet<Author> Authors { get; set; }
    DbSet<Book> Books { get; set; }
    DbSet<Order> Orders { get; set; }
    DbSet<AppUser> Users { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
