using DataAccess.Context;
using DataAccess.Interfaces;
using Entities.Models;

namespace DataAccess.Repositories;
public class AddressRepository : Repository<Address>, IAddressRepository
{
    public AddressRepository(AppDbContext context) : base(context)
    {
    }
}
