using Entities.Abstractions;

namespace Entities.Models;
public sealed class Language : Entity
{
    public string Name { get; set; } = string.Empty;
    public string Flag { get; set; } = string.Empty;
}
