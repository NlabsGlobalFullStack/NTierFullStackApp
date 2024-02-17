using DataAccess.Context;
using DataAccess.Interfaces;
using Entities.Models;

namespace DataAccess.Repositories;
public class BookDetailRepository : Repository<BookDetail>, IBookDetailRepository
{
    public BookDetailRepository(AppDbContext context) : base(context)
    {
    }
}
