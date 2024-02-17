namespace Entities.DTOs.Author;
public sealed record AuthorDto
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string Lastname { get; set; }
    public string AboutEn { get; set; }
    public string AboutTr { get; set; }
    public bool isActive { get; set; }
    public string ProfileImgUrl { get; set; } = string.Empty;
    public int PublishedBooksCount { get; set; }
}
