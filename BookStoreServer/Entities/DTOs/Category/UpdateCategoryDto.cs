namespace Entities.DTOs.Category;
public sealed record UpdateCategoryDto(
    int Id,
    string NameEn,
    string NameTr,
    string IconImgUrl,
    bool IsActive,
    bool IsDeleted);
