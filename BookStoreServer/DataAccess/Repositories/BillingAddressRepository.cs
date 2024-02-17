using DataAccess.Context;
using DataAccess.Interfaces;
using Entities.Models;

namespace DataAccess.Repositories;
public class BillingAddressRepository : Repository<BillingAddress>, IBillingAddressRepository
{
    public BillingAddressRepository(AppDbContext context) : base(context)
    {
    }
}
