using AutoMapper;
using Entities.DTOs.Author;
using Entities.Models;

namespace Business.Mapping;
public sealed class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateAuthorDto, Author>();
    }
}
