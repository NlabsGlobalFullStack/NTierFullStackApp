namespace Entities.DTOs.Category;
public sealed record CreateCategoryDto(
    string NameEn,
    string NameTr,
    string IconImgUrl,
    bool IsActive = true,
    bool IsDeleted = false);
