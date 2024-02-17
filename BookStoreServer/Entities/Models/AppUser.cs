using Microsoft.AspNetCore.Identity;

namespace Entities.Models;
public sealed class AppUser : IdentityUser<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName => string.Join(" ", this.FirstName, this.LastName);
}
