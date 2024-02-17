namespace Business.Services;

internal interface IService<TEntity, TDto>
    where TEntity : class
    where TDto : class
{
}