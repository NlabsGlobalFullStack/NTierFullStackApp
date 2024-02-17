using Entities.Abstractions;

namespace DataAccess.Interfaces;
public interface IRepository<T>
        where T : Entity
{
    IQueryable<T> GetAllReturnIQueryable();
    Task<Guid> AddAsync(T entity, CancellationToken cancellationToken = default);
    Task<bool> Add(T entity);
    Task<bool> UpdateAsync(T entity);
    Task<bool> DeleteByIdAsync(Guid id);
    Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default);
}
