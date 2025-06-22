using System.Net.Mail;

namespace Portfolio.Domain.Entities;

/// <summary>
/// Represents a way to contact the person: email, phone, or social link.
/// </summary>
public class ContactInfo : BaseEntity
{
    /// <summary>
    /// Gets the type of contact information (e.g., Email, Phone, Url).
    /// </summary>
    public ContactType Type { get; private set; }

    /// <summary>
    /// Gets the value of the contact information (e.g., email address, phone number, URL).
    /// </summary>
    public string Value { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ContactInfo"/> class.
    /// Validates the value based on the contact type.
    /// </summary>
    /// <param name="type">The type of contact information.</param>
    /// <param name="value">The value of the contact information.</param>
    /// <exception cref="ArgumentException">
    /// Thrown if the value is not a valid email address or URL when the type requires it.
    /// </exception>
    public ContactInfo(ContactType type, string value)
    {
        Type = type;
        Value = type switch
        {
            ContactType.Email when !MailAddress.TryCreate(value, out _)
                => throw new ArgumentException("Invalid email", nameof(value)),
            ContactType.Url when !Uri.IsWellFormedUriString(value, UriKind.Absolute)
                => throw new ArgumentException("Invalid URL", nameof(value)),
            _ => value
        };
    }

    /// <summary>
    /// Updates the contact information type and value.
    /// </summary>
    /// <param name="type">The new contact type.</param>
    /// <param name="value">The new contact value.</param>
    public void Update(ContactType type, string value)
    {
        Type = type;
        Value = value;
    }
}

/// <summary>
/// Enumerates the types of contact information.
/// </summary>
public enum ContactType
{
    /// <summary>
    /// Email address.
    /// </summary>
    Email,
    /// <summary>
    /// Phone number.
    /// </summary>
    Phone,
    /// <summary>
    /// URL (e.g., website or social profile).
    /// </summary>
    Url
}
