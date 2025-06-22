namespace Portfolio.Domain.Entities;

/// <summary>
/// Represents a person entity in the portfolio domain.
/// </summary>
public class Person : BaseEntity
{
    /// <summary>
    /// Gets the full name of the person.
    /// </summary>
    public string FullName { get; private set; }

    /// <summary>
    /// Gets the biography of the person.
    /// </summary>
    public string Bio { get; private set; }

    /// <summary>
    /// Gets the profile image of the person as a base64 string or URL.
    /// </summary>
    public string ProfileImage { get; private set; }

    /// <summary>
    /// Gets the social banner image of the person as a base64 string or URL.
    /// </summary>
    public string SocialBannerImage { get; private set; }

    // navigation
    public IEnumerable<Project> Projects { get; private set; } = Enumerable.Empty<Project>();


    /// <summary>
    /// Initializes a new instance of the <see cref="Person"/> class.
    /// </summary>
    /// <param name="fullName">The full name of the person.</param>
    /// <param name="bio">The biography of the person.</param>
    /// <param name="profileImage">The profile image of the person.</param>
    /// <param name="socialBannerImage">The social banner image of the person.</param>
    public Person(string fullName, string bio, string profileImage, string socialBannerImage)
    {
        FullName = fullName;
        Bio = bio;
        ProfileImage = profileImage;
        SocialBannerImage = socialBannerImage;
    }

    /// <summary>
    /// Updates the profile information for the person.
    /// </summary>
    /// <param name="fullName">The new full name.</param>
    /// <param name="bio">The new biography.</param>
    public void UpdateProfile(string fullName, string bio)
    {
        FullName = fullName;
        Bio = bio;
    }
}
