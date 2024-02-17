using Entities.ValueObjects;

namespace Entities.Models;
public sealed class ShoppingCart
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public AppUser? AppUser { get; set; }
    public List<ShoppingCartDetail>? ShoppingCartDetails { get; set; }
    public Money? TotalPrice { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime? UpdatedDate { get; set; }
}
