using AutoMapper;
using Business.Interfaces;
using DataAccess.Interfaces;
using Entities.DTOs.Author;
using Entities.Models;

namespace Business.Services;
public class AuthorService : Service<Author, AuthorDto, CreateAuthorDto, UpdateAuthorDto>, IAuthorService
{
    private readonly IAuthorRepository _authorRepository;

    public AuthorService(IAuthorRepository authorRepository, IMapper mapper)
        : base(authorRepository, mapper)
    {
        _authorRepository = authorRepository;
    }
}
