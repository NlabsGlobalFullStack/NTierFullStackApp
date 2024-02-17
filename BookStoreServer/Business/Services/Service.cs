using AutoMapper;
using Business.Interfaces;
using DataAccess.Interfaces;
using Entities.Abstractions;

namespace Business.Services;

public class Service<TEntity, TDto, TCreateDto, TUpdateDto> : IService<TEntity, TDto, TCreateDto, TUpdateDto>
        where TEntity : Entity
        where TDto : class
        where TCreateDto : class
        where TUpdateDto : class
{
    private readonly IRepository<TEntity> _repository;
    private readonly IMapper _mapper;

    public Service(IRepository<TEntity> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<Guid> AddAsync(TCreateDto dto, CancellationToken cancellationToken = default)
    {
        var entity = _mapper.Map<TEntity>(dto);
        var result = await _repository.AddAsync(entity, cancellationToken);
        if (result == Guid.Empty)
        {
            throw new ArgumentException("Kayıt işlemi esnasında bir hata oluştu");
        }
        return result;
    }

    public async Task<bool> UpdateAsync(Guid id, TUpdateDto dto)
    {
        var existingEntity = await _repository.GetByIdAsync(id);
        if (existingEntity is null)
        {
            throw new ArgumentException("Güncelleme işlemi esnasında bir hata oluştu");
        }

        _mapper.Map(dto, existingEntity);
        await _repository.UpdateAsync(existingEntity);
        return true;
    }

    public async Task<bool> DeleteByIdAsync(Guid id)
    {
        var result = await _repository.DeleteByIdAsync(id);
        if (!result)
        {
            throw new ArgumentException("Silme işlemi esnasında bir hata oluştu");
        }
        return true;
    }

    public async Task<TDto> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var entity = await _repository.GetByIdAsync(id, cancellationToken);
        if (entity is null)
            throw new ArgumentException("Kayıt bulunamadı!");
        return _mapper.Map<TDto>(entity);
    }

    public async Task<List<TDto>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var entities = await _repository.GetAllAsync(cancellationToken);
        return _mapper.Map<List<TDto>>(entities);
    }

    public IQueryable<TDto> GetAllReturnIQueryable()
    {
        var entities = _repository.GetAllReturnIQueryable();
        if (entities is null)
        {
            throw new ArgumentException("Listeleme sırasında bir hata oluştu");
        }
        return _mapper.ProjectTo<TDto>(entities);
    }
}