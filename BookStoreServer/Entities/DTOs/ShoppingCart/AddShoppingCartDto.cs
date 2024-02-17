using Entities.ValueObjects;

namespace Entities.DTOs.ShoppingCart;
public sealed record AddShoppingCartDto(
    int BookId,
    Money Price,
    int Quantity,
    int AppUserId);