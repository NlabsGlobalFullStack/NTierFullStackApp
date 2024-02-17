using Entities.ValueObjects;

namespace Entities.Models;
public sealed class ShoppingCartDetail
{
    public Guid Id { get; set; }
    public Guid ShoppingCartId { get; set; }
    public ShoppingCart? ShoppingCart { get; set; }

    public Guid BookId { get; set; }
    public Book? Book { get; set; }

    public int Quantity { get; set; }
    public Money? Price { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.Now;
}
