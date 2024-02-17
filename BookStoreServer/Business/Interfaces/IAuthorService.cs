using Entities.DTOs.Author;
using Entities.Models;

namespace Business.Interfaces;
public interface IAuthorService : IService<Author, AuthorDto, CreateAuthorDto, UpdateAuthorDto>
{
}
