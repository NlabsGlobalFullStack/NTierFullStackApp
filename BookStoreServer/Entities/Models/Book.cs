using Entities.Abstractions;
using Entities.ValueObjects;

namespace Entities.Models;
public sealed class Book : Entity
{
    public Guid AuthorId { get; set; }
    public Author? Author { get; set; }
    public Guid BookLanguageId { get; set; }
    public BookLanguage? BookLanguage { get; set; }
    public Guid BookDetailId { get; set; }
    public BookDetail? BookDetail { get; set; }
    public string Title { get; set; } = string.Empty;
    public Guid BookDescriptionId { get; set; }
    public List<BookDescription>? BookDescriptions { get; set; }
    public string Publisher { get; set; } = string.Empty;
    public Money Price { get; set; } = new(0, "₺");
    public string ImageUrl { get; set; } = string.Empty;
    public int Quantity { get; set; } = 0;
    public bool IsFeatured { get; set; } = false;
}
