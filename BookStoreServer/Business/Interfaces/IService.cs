using Entities.Abstractions;

namespace Business.Interfaces;
public interface IService<TEntity, TDto, TCreateDto, TUpdateDto>
        where TEntity : Entity
        where TDto : class
        where TCreateDto : class
        where TUpdateDto : class
{
    IQueryable<TDto> GetAllReturnIQueryable();
    Task<Guid> AddAsync(TCreateDto dto, CancellationToken cancellationToken = default);
    Task<bool> UpdateAsync(Guid id, TUpdateDto dto);
    Task<bool> DeleteByIdAsync(Guid id);
    Task<TDto> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<List<TDto>> GetAllAsync(CancellationToken cancellationToken = default);
}


