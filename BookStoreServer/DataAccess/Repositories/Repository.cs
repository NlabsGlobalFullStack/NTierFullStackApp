using DataAccess.Context;
using DataAccess.Interfaces;
using Entities.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories;
public class Repository<T> : IRepository<T>
        where T : Entity, new()
{
    private readonly AppDbContext _context;

    public DbSet<T> Entity;

    public Repository(AppDbContext context)
    {
        _context = context;
        Entity = context.Set<T>();
    }

    public async Task<bool> Add(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<Guid> AddAsync(T entity, CancellationToken cancellationToken = default)
    {
        await Entity.AddAsync(entity, cancellationToken);
        await _context.SaveChangesAsync();
        return entity.Id;
    }

    public async Task<bool> UpdateAsync(T entity)
    {
        Entity.Update(entity);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteByIdAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity == null)
        {
            return false;
        }

        Entity.Remove(entity);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await Entity.AsNoTracking().ToListAsync(cancellationToken);
    }

    public async Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await Entity.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id, cancellationToken);
    }

    public IQueryable<T> GetAllReturnIQueryable()
    {
        return Entity.AsQueryable();
    }
}}