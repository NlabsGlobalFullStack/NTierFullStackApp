namespace Entities.DTOs.Shared;
public sealed record RequestDto(
    int? AuthorId,
    int? CategoryId,
    int? LanguageId,
    //string LanguageEn,
    //string LanguageTr,
    int PageNumber,
    int PageSize,
    string Search,
    string OrderBy);