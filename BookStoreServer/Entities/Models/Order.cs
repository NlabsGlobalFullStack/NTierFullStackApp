using Entities.Abstractions;

namespace Entities.Models;
public sealed class Order : Entity
{
    public string OrderNumber { get; set; } = string.Empty;
    public Guid UserId { get; set; }
    public AppUser? User { get; set; }
    public int ProductQuantity { get; set; }
    public DateTime PaymentDate { get; set; } = DateTime.Now;
    public List<OrderPaymentMethod>? OrderPaymentMethods { get; set; }
    public string PaymentNumber { get; set; } = string.Empty;
    public Guid OrderStatusId { get; set; }
    public OrderStatus? OrderStatus { get; set; }
    public string PaymentCurrency { get; set; } = string.Empty;
    public List<OrderDetail>? OrderDetails { get; set; }
    public string Comment { get; set; } = string.Empty;
    public short? Raiting { get; set; }
}
