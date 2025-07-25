using CarManagement.Core.Common;
using CarManagement.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace CarManagement.DAL.Repositories;

public class Repository<T> : IRepository<T> where T : BaseEntity
{
    private readonly AppDbContext _context = new();

    private readonly DbSet<T> Table;
    public Repository()
    {
        Table = _context.Set<T>();
    }
    public async Task AddAsync(T entity)
    {
        await Table.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var data = await GetByIdAsync(id);
        Table.Remove(data);

    }

    public Task<List<T>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        var data = await Table.FirstOrDefaultAsync(x => x.Id == id);
        return data;
    }

    public Task UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }
}
