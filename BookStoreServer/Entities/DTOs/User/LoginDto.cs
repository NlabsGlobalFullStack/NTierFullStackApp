namespace Entities.DTOs.User;
public sealed record LoginDto(
    string UserNameOrEmail,
    string Password,
    bool RemeberMe = false);
