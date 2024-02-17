using Entities.ValueObjects;

namespace Entities.DTOs.ShoppingCart;
public sealed record SetShoppingCartsDto(
    int BookId,
    int AppUserId,
    int Quantity,
    Money Price);