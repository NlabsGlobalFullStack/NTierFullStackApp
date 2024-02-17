namespace Entities.DTOs.User;
public sealed record LoginResponseDto(
    string Token,
    int UserId,
    string UserName);

