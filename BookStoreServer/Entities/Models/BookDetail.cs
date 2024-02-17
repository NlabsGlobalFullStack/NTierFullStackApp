using Entities.Abstractions;

namespace Entities.Models;
public sealed class BookDetail : Entity
{
    public Guid BookId { get; set; }
    public Book? Book { get; set; }
    public int Page { get; set; } = 0;
    public string ISBN { get; set; } = string.Empty;
    public string PublicationDate { get; set; } = string.Empty;
    public List<BookPublicationCityCountry>? PublicationCityCountries { get; set; }
}
