using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;
public sealed class BookCategory
{
    //Composite Key
    [ForeignKey("Book")]
    public Guid BookId { get; set; }
    public Book? Book { get; set; }


    [ForeignKey("Category")]
    public Guid CategoryId { get; set; }
    public Category? Category { get; set; }
}
