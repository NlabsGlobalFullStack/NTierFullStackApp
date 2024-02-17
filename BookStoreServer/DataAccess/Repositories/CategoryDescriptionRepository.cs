using DataAccess.Context;
using DataAccess.Interfaces;
using Entities.Models;

namespace DataAccess.Repositories;
public class CategoryDescriptionRepository : Repository<CategoryDescription>, ICategoryDescriptionRepository
{
    public CategoryDescriptionRepository(AppDbContext context) : base(context)
    {
    }
}
