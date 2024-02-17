using DataAccess.Context;
using DataAccess.Interfaces;
using Entities.Models;

namespace DataAccess.Repositories;
public class BookDiscountRepository : Repository<BookDiscount>, IBookDiscountRepository
{
    public BookDiscountRepository(AppDbContext context) : base(context)
    {
    }
}
