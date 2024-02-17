namespace Entities.Models;
public sealed class ReviewTitle
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid LanguageId { get; set; }
    public Language? Language { get; set; }
    public Guid ReviewId { get; set; }
    public Review? Review { get; set; }
    public string? Title { get; set; } = string.Empty;
}
