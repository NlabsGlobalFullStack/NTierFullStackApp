﻿using Entities.ValueObjects;

namespace Entities.DTOs.Book;
public sealed record UpdateBookDto(
    int Id,
    string Title,
    int AuthorId,
    int BookDetailId,
    int BookLanguageId,
    string DescriptionEn,
    string DescriptionTr,
    string Publisher,
    Money Price,
    string ImgUrl,
    int Quantity,
    bool IsFeatured,
    List<int> CategoryIds);
