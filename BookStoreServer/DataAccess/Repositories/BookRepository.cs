using DataAccess.Context;
using DataAccess.Interfaces;
using Entities.Models;

namespace DataAccess.Repositories;
public class BookRepository : Repository<Book>, IBookRepository
{
    public BookRepository(AppDbContext context) : base(context)
    {
    }
}
