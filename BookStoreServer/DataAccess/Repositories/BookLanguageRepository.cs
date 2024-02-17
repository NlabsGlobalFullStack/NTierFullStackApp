using DataAccess.Context;
using DataAccess.Interfaces;
using Entities.Models;

namespace DataAccess.Repositories;
public class BookLanguageRepository : Repository<BookLanguage>, IBookLanguageRepository
{
    public BookLanguageRepository(AppDbContext context) : base(context)
    {
    }
}
