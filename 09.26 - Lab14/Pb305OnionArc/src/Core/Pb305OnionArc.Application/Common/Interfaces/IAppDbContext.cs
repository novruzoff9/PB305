using Microsoft.EntityFrameworkCore;
using Pb305OnionArc.Domain.Models;

namespace Pb305OnionArc.Application.Common.Interfaces;

public interface IAppDbContext
{
    DbSet<Author> Authors { get; set; }
    DbSet<Book> Books { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
