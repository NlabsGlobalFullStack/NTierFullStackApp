using Entities.Abstractions;

namespace Entities.Models;
public sealed class BookDiscount : Entity
{
    public Guid BookId { get; set; }
    public Book? Book { get; set; }
    public int DiscountPercentage { get; set; } = 0;
    public DateTime StartDate { get; set; } = DateTime.Now;
    public DateTime EndDate { get; set; } = DateTime.Now;
    public decimal DiscountedPrice => DiscountPercentage == 0 ? Book!.Price.Value : Book!.Price.Value - (Book.Price.Value * DiscountPercentage / 100);
}
