namespace Entities.Models;
public sealed class OrderStatus
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid OrderId { get; set; }
    public Order? Order { get; set; }
    public List<OrderStatusDetail>? OrderStatusDetails { get; set; }
}
