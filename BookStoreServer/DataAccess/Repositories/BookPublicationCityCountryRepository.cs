using DataAccess.Context;
using DataAccess.Interfaces;
using Entities.Models;

namespace DataAccess.Repositories;
public class BookPublicationCityCountryRepository : Repository<BookPublicationCityCountry>, IBookPublicationCityCountryRepository
{
    public BookPublicationCityCountryRepository(AppDbContext context) : base(context)
    {
    }
}
