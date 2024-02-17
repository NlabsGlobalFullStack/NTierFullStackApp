using Entities.Models;

namespace Entities.DTOs.Book;
public class BookDetailDto
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public BookDto? Book { get; set; }
    public int Page { get; set; } = 0;
    public string ISBN { get; set; } = string.Empty;
    public string PublicationDate { get; set; } = string.Empty;
    public string PublicationCityCountryEn { get; set; } = string.Empty;
    public string PublicationCityCountryTr { get; set; } = string.Empty;
}
