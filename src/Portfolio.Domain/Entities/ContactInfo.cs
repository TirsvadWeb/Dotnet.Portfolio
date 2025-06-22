using System.Net.Mail;

namespace Portfolio.Domain.Entities;

/// <summary>
/// Represents a way to contact the person: email, phone, social link.
/// </summary>
public class ContactInfo : BaseEntity
{
    public ContactType Type { get; private set; }
    public string Value { get; private set; }

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

    public void Update(ContactType type, string value)
    {
        Type = type;
        Value = value;
    }
}

public enum ContactType
{
    Email,
    Phone,
    Url
}
