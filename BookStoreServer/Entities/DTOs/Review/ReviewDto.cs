using Entities.Models;

namespace Entities.DTOs.Review;
public sealed record ReviewDto
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public Book? Book { get; set; }
    public Guid AppUserId { get; set; }
    public AppUser? AppUser { get; set; }
    public short Raiting { get; set; }
    public string? TitleEn { get; set; } = string.Empty;
    public string? TitleTr { get; set; } = string.Empty;
    public string? CommentEn { get; set; } = string.Empty;
    public string? CommentTr { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}
