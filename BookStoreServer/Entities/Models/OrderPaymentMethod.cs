using Entities.Abstractions;

namespace Entities.Models;
public sealed class OrderPaymentMethod : Entity
{
    public Guid LanguageId { get; set; }
    public Language? Language { get; set; }
    public string Method { get; set; } = string.Empty;
}
