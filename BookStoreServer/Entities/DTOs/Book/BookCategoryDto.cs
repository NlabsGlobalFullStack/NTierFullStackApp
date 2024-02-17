namespace Entities.DTOs.Book;
public sealed record BookCategoryDto
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}
