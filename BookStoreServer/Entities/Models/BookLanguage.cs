using Entities.Abstractions;

namespace Entities.Models;
public sealed class BookLanguage : Entity
{
    public Guid LanguageId { get; set; }
    public Language? Language { get; set; }
    public string Name { get; set; } = string.Empty;
}
