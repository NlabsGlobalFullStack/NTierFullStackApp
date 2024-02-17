using Entities.Abstractions;

namespace Entities.Models;
public sealed class BillingAddress : Entity
{
    public Guid AppUserId { get; set; }
    public AppUser? AppUser { get; set; }
    public string Country { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string? ZipCode { get; set; }
    public string ContactName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
