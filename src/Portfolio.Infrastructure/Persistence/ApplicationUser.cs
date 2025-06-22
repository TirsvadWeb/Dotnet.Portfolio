using Microsoft.AspNetCore.Identity;

namespace Portfolio.Infrastructure.Persistence;

/// <summary>
/// Represents an application user with identity and authentication information.
/// Extend this class to add custom profile data for application users.
/// </summary>
public class ApplicationUser : IdentityUser
{
}
