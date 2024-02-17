using Entities.ValueObjects;

namespace Entities.Models;
public sealed class WishList
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public Book? Book { get; set; }
    public Guid AppUserId { get; set; }
    public AppUser? AppUser { get; set; }
    public Money Price { get; set; } = new(0, "₺");
}
