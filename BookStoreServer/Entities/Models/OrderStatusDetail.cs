using Entities.Enums;

namespace Entities.Models;
public sealed class OrderStatusDetail
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid LanguageId { get; set; }
    public Language? Language { get; set; }
    public Guid OrderStatusId { get; set; }
    public OrderStatus? OrderStatus { get; set; }
    public string Status { get; set; } = string.Empty;
    public DateTime StatusDate { get; set; } = DateTime.Now;
}
