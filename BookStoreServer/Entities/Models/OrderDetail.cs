using Entities.ValueObjects;

namespace Entities.Models;
public sealed class OrderDetail
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid OrderId { get; set; }
    public Order? Order { get; set; }
    public Guid BookId { get; set; }
    public Book? Book { get; set; }
    public int Quantity { get; set; }
    public Money Price { get; set; } = new(0, "₺");
}
