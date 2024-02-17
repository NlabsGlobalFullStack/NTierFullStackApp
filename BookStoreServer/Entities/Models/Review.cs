using Entities.Abstractions;

namespace Entities.Models;
public sealed class Review : Entity
{
    public Guid BookId { get; set; }
    public Book? Book { get; set; }
    public Guid AppUserId { get; set; }
    public AppUser? AppUser { get; set; }
    public short Raiting { get; set; }
    public List<ReviewTitle>? ReviewTitles { get; set; }
    public List<ReviewComment>? ReviewComments { get; set; }
}
