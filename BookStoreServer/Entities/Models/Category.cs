using Entities.Abstractions;

namespace Entities.Models;
public sealed class Category : Entity
{
    public List<CategoryDescription>? CategoryDescriptions { get; set; }
    public string IconImgUrl { get; set; } = string.Empty;
}
