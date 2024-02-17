using Entities.Abstractions;

namespace Entities.Models;
public sealed class Author : Entity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set;} = string.Empty;
    public string About { get; set; } = string.Empty;
    public string ProfileImgUrl { get; set; } = string.Empty;
    public int PublishedBooksCount { get; set; }
}
