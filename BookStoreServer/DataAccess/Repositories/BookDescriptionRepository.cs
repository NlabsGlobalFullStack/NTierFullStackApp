using DataAccess.Context;
using DataAccess.Interfaces;
using Entities.Models;

namespace DataAccess.Repositories;
public class BookDescriptionRepository : Repository<BookDescription>, IBookDescriptionRepository
{
    public BookDescriptionRepository(AppDbContext context) : base(context)
    {
    }
}
