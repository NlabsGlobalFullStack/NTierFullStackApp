using Entities.ValueObjects;

namespace Entities.DTOs.Wishlist;
public sealed record class AddToWishListDto(
    int BookId,
    int AppUserId,
    Money Price);
